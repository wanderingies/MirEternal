//------------------------------------------------------------------------------
//  此代码版权（除特别声明或在XREF结尾的命名空间的代码）归作者本人若汝棋茗所有
//  源代码使用协议遵循本仓库的开源协议及附加协议，若本仓库没有设置，则按MIT开源协议授权
//  CSDN博客：https://blog.csdn.net/qq_40374647
//  哔哩哔哩视频：https://space.bilibili.com/94253567
//  Gitee源代码仓库：https://gitee.com/RRQM_Home
//  Github源代码仓库：https://github.com/RRQM
//  API首页：http://rrqm_home.gitee.io/touchsocket/
//  交流QQ群：234762506
//  感谢您的下载和使用
//------------------------------------------------------------------------------
//------------------------------------------------------------------------------
using System;

namespace TouchSocket.Core
{
    /// <summary>
    /// 转换器接口
    /// </summary>
    public interface IConverter<TSource>
    {
        /// <summary>
        /// 转换器执行顺序
        /// <para>该属性值越小，越靠前执行。值相等时，按添加先后顺序</para>
        /// <para>该属性效果，仅在<see cref="TouchSocketConverter{TSource}.Add(IConverter{TSource})"/>之前设置有效。</para>
        /// </summary>
        int Order { get; set; }

        /// <summary>
        /// 尝试将源数据转换目标类型对象
        /// </summary>
        /// <param name="source"></param>
        /// <param name="targetType"></param>
        /// <param name="target"></param>
        /// <returns></returns>
        bool TryConvertFrom(TSource source, Type targetType, out object target);

        /// <summary>
        /// 尝试将目标类型对象转换源数据
        /// </summary>
        /// <param name="target"></param>
        /// <param name="source"></param>
        /// <returns></returns>
        bool TryConvertTo(object target, out TSource source);
    }
}