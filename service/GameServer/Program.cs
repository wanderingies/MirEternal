#pragma warning disable CS8618

using GameServer.Data;
using GameServer.Packs;
using GameServer.Service;
using GameServer.Template;
using GameServer.Utility;
using System.Runtime.InteropServices;
using TouchSocket.Core;
using TouchSocket.Sockets;

namespace GameServer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            _rolebox = new Rolebox();

            #region Template

            /*var templates = Reflection.CreateAllInstancesOf<TemplateInterface>().OrderBy(q => q.TemplateLevel);
            foreach (var template in templates)
                template.ReaderTemplate();*/
            #endregion

            #region GameService

            service = new GameService();

            service.Setup(new TouchSocketConfig()//载入配置     
                .SetListenIPHosts("tcp://127.0.0.1:29300")
                .ConfigureContainer(a =>//容器的配置顺序应该在最前面
                {
                    a.AddConsoleLogger();
                    a.AddFileLogger("logs\\GameServer");
                })
                .ConfigurePlugins(a =>
                {
                    a.UseReconnection()
                     .SetTick(TimeSpan.FromSeconds(1))
                     .UsePolling();
                }))
                .Start();//启动            

            service.Logger.Info("游戏服务器启动成功");
            #endregion

            bool isSuccess = SetConsoleCtrlHandler(consoleCtrlDelegate, true);
            Thread.CurrentThread.IsBackground = false;
            Thread.Sleep(Timeout.Infinite);
        }
        
        public static GameService service;

        private static Rolebox _rolebox;

        #region capture event

        #region kernel32

        private delegate bool ConsoleEventDelegate(int eventType);

        [DllImport("kernel32.dll", SetLastError = true)]
        private static extern bool SetConsoleCtrlHandler(ConsoleEventDelegate callback, bool add);

        volatile static ConsoleEventDelegate consoleCtrlDelegate = new ConsoleEventDelegate(HandlerRoutine);

        #endregion

        public static bool HandlerRoutine(int CtrlType)
        {
            switch (CtrlType)
            {
                case 0:
                    break;
                case 2:
                    break;
            }

            return false;
        }
        #endregion
    }
}

/// <summary>
/// 版本
/// <para>4: 文件</para>
/// <para>4: 重构</para>
/// <para>0: 错误</para>
/// <para>0: 更新</para>
/// </summary>
//public const string Version = "4.4.0.6";
//public const string FileVersion = "1.0.409";

/// <summary>
/// 10366
/// </summary>
//public const int PrivateVersion = 2088641520;

/// <summary>
/// 10370
/// </summary>
//public const int PrivateVersion = 478716885;

/// <summary>
/// 10375
/// </summary>
//public const int PrivateVersion = 478716885;