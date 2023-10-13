﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

using Configurations.Concurrent;
using Configurations.Utils;
using Configurations.IO;
using Configurations.Threading;

namespace Configurations.Core
{
    /// <summary>
    /// 提供一个基于文件的配置管理器。
    /// </summary>
    public class FileConfigurationRepo : AsynchronousConfigurationRepo
    {
        /// <summary>
        /// 获取此配置所用的文件。
        /// </summary>
        private readonly FileInfo _file;

        /// <summary>
        /// 用于监视文件改变（包括创建和删除）。
        /// </summary>
        private readonly FileWatcher? _watcher;

        /// <summary>
        /// 提供循环可等待操作。
        /// </summary>
        private readonly PartialAwaitableRetry _saveLoop;

        /// <summary>
        /// 存储运行时保存的键值对。
        /// </summary>
        private readonly FileDictionarySynchronizer<string, string> _keyValueSynchronizer;

        /// <summary>
        /// 当前正在读文件的可等待任务。如果试图读配置，则应该等待此任务完成。
        /// </summary>
        private Task _currentReadingFileTask;

        /// <summary>
        /// 发现文件已改变，正在等待重新读取文件。
        /// </summary>
        private bool _isPendingReload;

        /// <summary>
        /// 发现文件改变，并且在读取的过程中又改变了，因此可能有必要重读。
        /// </summary>
        private bool _isPendingReloadReentered;

        /// <summary>
        /// 获取为了同步此配置时，耗在等待上的次数。
        /// </summary>
        private volatile int _syncWaitingCount;

        /// <summary>
        /// 初始化使用 <paramref name="fileName"/> 作为配置文件的 <see cref="FileConfigurationRepo"/> 的新实例。
        /// </summary>
        /// <param name="fileName">配置文件的文件路径。</param>
        [Obsolete("请改用线程安全的 ConfigurationFactory 来创建实例。")]
        [EditorBrowsable(EditorBrowsableState.Never)]
        public FileConfigurationRepo(string fileName) : this(fileName, RepoSyncingBehavior.Sync) { }

        /// <summary>
        /// 初始化使用 <paramref name="fileName"/> 作为配置文件的 <see cref="FileConfigurationRepo"/> 的新实例。
        /// </summary>
        /// <param name="fileName">配置文件的文件路径。</param>
        /// <param name="syncingBehavior">指定应如何读取数据。是实时监听文件变更，还是只读一次，后续不再监听变更。后者性能更好。</param>
        internal FileConfigurationRepo(string fileName, RepoSyncingBehavior syncingBehavior)
        {
            if (fileName == null)
            {
                throw new ArgumentNullException(nameof(fileName));
            }

            var fullPath = Path.GetFullPath(fileName);
            _file = new FileInfo(fullPath);
            _saveLoop = new PartialAwaitableRetry(LoopSyncTask);
            _keyValueSynchronizer = new FileDictionarySynchronizer<string, string>(_file,
#pragma warning disable CS8620 // 由于引用类型的可为 null 性差异，实参不能用于形参。
                x => CoinConfigurationSerializer.Serialize(x),
#pragma warning restore CS8620 // 由于引用类型的可为 null 性差异，实参不能用于形参。
                x => CoinConfigurationSerializer.Deserialize(x),
                // 因为 COIN 格式的序列化器默认会写“文件头”，导致即使是构造函数也会和原始文件内容不同，于是会写入文件，导致写入次数比预期多一些。
                // 所以，比较差异时使用 KeyValueEquals 而不是 WholeTextEquals，这可以在目前对注释不敏感的时候提升一些性能。
                FileEqualsComparison.KeyValueEquals);

            // 监视文件改变。
            if (syncingBehavior == RepoSyncingBehavior.Sync)
            {
                _watcher = new FileWatcher(_file);
                _currentReadingFileTask = FastSynchronizeAsync();
                _watcher.Changed += OnFileChanged;
                _ = _watcher.WatchAsync();
            }
            else
            {
                _currentReadingFileTask = FastSynchronizeAsync();
            }
        }

        /// <summary>
        /// 在文件改变后的延迟读取时间。
        /// </summary>
        public TimeSpan DelayReadTime { get; set; } = TimeSpan.FromMilliseconds(1);

        /// <summary>
        /// 延迟保存的时间
        /// </summary>
        public TimeSpan DelaySaveTime { get; set; } = TimeSpan.FromMilliseconds(1);

        /// <summary>
        /// 获取此配置与文件同步的总尝试次数（包含失败的尝试）。
        /// </summary>
        public int FileSyncingCount => _keyValueSynchronizer.FileSyncingCount;

        /// <summary>
        /// 获取此配置与文件的同步失败次数。
        /// </summary>
        public int FileSyncingErrorCount => _keyValueSynchronizer.FileSyncingErrorCount;

        /// <summary>
        /// 获取为了同步此配置时，耗在等待上的次数。
        /// </summary>
        public int SyncWaitingCount => _syncWaitingCount;

        /// <summary>
        /// 如果此文件所在的分区支持高精度时间，则此值为 true，否则为 false。
        /// 当此值为 false 时，将不能依赖于时间判定文件内容的改变；当为 true 时，大概率可以依赖时间来判定文件内容的改变。
        /// </summary>
        public bool SupportsHighResolutionFileTime => _keyValueSynchronizer.SupportsHighResolutionFileTime;

        /// <summary>
        /// 获取所有目前已经存储的 Key 的集合。
        /// </summary>
        protected override ICollection<string> GetKeys() => _keyValueSynchronizer.Dictionary.Keys;

        /// <summary>
        /// 获取指定 Key 的值，如果不存在，需要返回 null。
        /// </summary>
        /// <param name="key">指定项的 Key。</param>
        /// <returns>
        /// 执行项的 Key，如果不存在，则为 null / Task&lt;string&gt;.FromResult(null)"/>。
        /// </returns>
        protected override async Task<string?> ReadValueCoreAsync(string key)
        {
            await _currentReadingFileTask.ConfigureAwait(false);
            var value = _keyValueSynchronizer.Dictionary.TryGetValue(key, out var v) ? v : null;
            CT.Log($"GET {key} = {value ?? "null"}", _file.Name);
            return value;
        }

        /// <summary>
        /// 为指定的 Key 存储指定的值。
        /// </summary>
        /// <param name="key">指定项的 Key。</param>
        /// <param name="value">要存储的值。</param>
        protected override async Task WriteValueCoreAsync(string key, string value)
        {
            value = value ?? throw new ArgumentNullException(nameof(value));
            value = value.Replace(Environment.NewLine, "\n");
            await _currentReadingFileTask.ConfigureAwait(false);
            CT.Log($"SET {key} = {value}", _file.Name);
            _keyValueSynchronizer.Dictionary[key] = value;
        }

        /// <summary>
        /// 将为指定的 Key 清除。
        /// </summary>
        /// <param name="key">指定项的 Key。</param>
        protected override async Task RemoveValueCoreAsync(string key)
        {
            await _currentReadingFileTask.ConfigureAwait(false);
            CT.Log($"CLEAN {key} = null", _file.Name);
            _keyValueSynchronizer.Dictionary.TryRemove(key, out _);
        }

        /// <summary>
        /// 在每次有键值改变后触发，在此处将配置进行持久化。
        /// </summary>
        /// <param name="context">用于追踪异步操作。</param>
        protected override void OnChanged(AsynchronousConfigurationChangeContext context)
        {
            context = context ?? throw new ArgumentNullException(nameof(context));
            var task = SaveAsync(-1);
            context.TrackAsyncAction(task);
        }

        /// <summary>
        /// 请求将文件与内存模型进行同步。
        /// 当采用不安全的读写文件策略时，有可能发生文件读写冲突；而发生时，会尝试 <paramref name="tryCount"/> 次。
        /// </summary>
        /// <param name="tryCount">
        /// 尝试次数。
        /// 当失败时会尝试重新同步，此值表示算上失败后限制的同步总次数。
        /// -1 表示一直尝试直到成功。
        /// </param>
        /// <returns>可异步等待的对象。</returns>
        public async Task SaveAsync(int tryCount = 10)
        {
            CT.Log($"要求保存...", _file.Name);

            // 执行一次等待以便让代码中大量调用的同步（利用 PartialAwaitableRetry 的机制）共用同一个异步任务，节省资源。
            // 副作用是会慢一拍。
            Interlocked.Increment(ref _syncWaitingCount);
            await Task.Delay(DelaySaveTime).ConfigureAwait(false);

            // 执行同步。
            await SynchronizeAsync(tryCount).ConfigureAwait(false);
        }

        /// <summary>
        /// 尝试重新加载此配置文件的外部修改（例如使用其他编辑器或其他客户端修改的部分）。
        /// <para>外部修改会自动同步到此配置中，但此同步不会立刻发生，所以如果你明确知道外部修改了文件后需要立刻重新加载外部修改，才需要调用此方法。</para>
        /// </summary>
        public async Task ReloadExternalChangesAsync()
        {
            CT.Log($"强制重新读取文件...", _file.Name);
            // 如果之前正在读取文件，则等待文件读取完成。
            await _currentReadingFileTask.ConfigureAwait(false);
            // 现在，强制要求重新读取文件。
            _currentReadingFileTask = FastSynchronizeAsync();
            // 然后，等待重新读取完成。
            await _currentReadingFileTask.ConfigureAwait(false);
        }

        /// <summary>
        /// 在配置文件改变的时候，重新读取文件。
        /// </summary>
        /// <param name="sender"><see cref="FileWatcher"/>。</param>
        /// <param name="e">空事件参数。</param>
        private void OnFileChanged(object? sender, EventArgs e)
        {
            _ = HandleFileChangedAsync();
        }

        private async Task HandleFileChangedAsync()
        {
            if (_keyValueSynchronizer.DangerousCheckIfThisFileChangeIsFromSelf())
            {
                CT.Log($"忽略本进程导致的文件改变...", _file.Name);
                return;
            }
            else
            {
                CT.Log($"检测到文件被改变...", _file.Name);
            }

            var isPending = _isPendingReload;
            if (isPending)
            {
                // 如果发现已经在准备读取文件了，那么就告诉他又进来了一次，他可能还需要读。
                _isPendingReloadReentered = true;
                return;
            }

            _isPendingReload = true;

            try
            {
                do
                {
                    _isPendingReloadReentered = false;
                    // 等待时间为预期等待时间的 1/2，因为多数情况下，一次文件的改变会收到两次 Change 事件。
                    // 第一次是文件内容的写入，第二次是文件信息（如最近写入时间）的写入。
                    // Interlocked.Increment(ref _syncWaitingCount);
                    await Task.Delay((int)DelayReadTime.TotalMilliseconds / 2).ConfigureAwait(false);
                } while (_isPendingReloadReentered);

                // 如果之前正在读取文件，则等待文件读取完成。
                await _currentReadingFileTask.ConfigureAwait(false);

                // 现在重新读取。
                // - ~~重新读取文件时不影响对键值对的访问，所以不要求其他地方等待 ReadFromFileTask。~~
                // - 但是，如果正在序列化和保存文件，为了避免写入时覆盖未读取完的键值对，需要等待读取完毕。
                // ！特别注意！：外部写完文件后配置立刻读，读不到新值；需要调用 ReloadExternalChangesAsync 方法强制加载外部修改；否则将等待自动更新修改。
                _ = SynchronizeAsync();
            }
            finally
            {
                _isPendingReload = false;
            }
        }

        private async Task<OperationResult> LoopSyncTask(PartialRetryContext context)
        {
            context.StepCount = 10;
            CT.Log($"等待同步...", _file.Name);
            _keyValueSynchronizer.Synchronize();
            Interlocked.Increment(ref _syncWaitingCount);
            await Task.Delay(DelaySaveTime).ConfigureAwait(false);
            return true;
        }

        /// <summary>
        /// 省去任何中间等待环节，立即开始同步（但为了安全，无法省去进程安全区的等待）。
        /// </summary>
        /// <returns>可等待对象。</returns>
        private Task FastSynchronizeAsync() => Task.Run(() =>
        {
            CT.Log($"立即同步...", _file.Name);
            _keyValueSynchronizer.Synchronize();
        });

        /// <summary>
        /// 请求将文件与内存模型进行同步。
        /// 在读文件时调用此方法后，请将返回值赋值给 <see cref="_currentReadingFileTask"/> 以便让后续值的读取使用最新值。
        /// 在写入文件时调用此方法，请仅将返回值用于等待或忽视返回值，因为写入文件不影响后续读值。
        /// </summary>
        /// <param name="tryCount">尝试次数。当失败时会尝试重新同步，此值表示算上失败后限制的同步总次数。当设置为 -1 时表示无限次重试。</param>
        /// <returns>可异步等待的对象。</returns>
        private async Task SynchronizeAsync(int tryCount = -1)
        {
            // 在构造方法中执行时，可能为 null；因此需要判空（在构造函数中，不需要等待读取）。
            if (_currentReadingFileTask != null)
            {
                await _currentReadingFileTask.ConfigureAwait(false);
            }

            CT.Log($"申请同步...", _file.Name);
            await _saveLoop.JoinAsync(tryCount);
        }
    }
}
