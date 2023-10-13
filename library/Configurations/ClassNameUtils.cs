﻿using System;

namespace Configurations
{
    /// <summary>
    /// 包含类名相关的处理方法。
    /// </summary>
    internal static class ClassNameUtils
    {
        /// <summary>
        /// 当某个类型的派生类都以基类（<typeparamref name="T"/>）名称作为后缀时，去掉后缀取派生类名称的前面部分。
        /// </summary>
        /// <typeparam name="T">名称统一的基类名称。</typeparam>
        /// <param name="this">派生类的实例。</param>
        /// <returns>去掉后缀的派生类名称。</returns>
        internal static string GetClassNameWithoutSuffix<T>(this T @this)
        {
            if (@this is null)
            {
                throw new ArgumentNullException(nameof(@this));
            }

            var derivedTypeName = @this.GetType().Name;
            var baseTypeName = typeof(T).Name;
            // 截取子类名称中去掉基类后缀的部分。
            var name = derivedTypeName.EndsWith(baseTypeName, StringComparison.Ordinal)
                ? derivedTypeName.Substring(0, derivedTypeName.Length - baseTypeName.Length)
                : derivedTypeName;
            // 如果子类名称和基类完全一样，则直接返回子类名称。
            return string.IsNullOrWhiteSpace(name) ? derivedTypeName : name;
        }
    }
}
