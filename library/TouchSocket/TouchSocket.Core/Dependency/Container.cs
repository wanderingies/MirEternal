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
using System.Collections;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using TouchSocket.Resources;

namespace TouchSocket.Core
{
    /// <summary>
    /// IOC容器
    /// </summary>
    public class Container : IContainer
    {
        private readonly ConcurrentDictionary<string, DependencyDescriptor> m_registrations = new ConcurrentDictionary<string, DependencyDescriptor>();

        /// <summary>
        /// 返回迭代器
        /// </summary>
        /// <returns></returns>
        public IEnumerator<DependencyDescriptor> GetEnumerator()
        {
            return this.m_registrations.Values.ToList().GetEnumerator();
        }

        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        /// <param name="fromType"></param>
        /// <param name="key"></param>
        /// <returns></returns>
        public bool IsRegistered(Type fromType, string key = "")
        {
            return fromType == typeof(IContainer) ? true : this.m_registrations.ContainsKey($"{fromType.FullName}{key}");
        }

        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        /// <param name="descriptor"></param>
        /// <param name="key"></param>
        public void Register(DependencyDescriptor descriptor, string key = "")
        {
            var k = $"{descriptor.FromType.FullName}{key}";
            this.m_registrations.AddOrUpdate(k, descriptor, (k, v) => { return descriptor; });
        }

        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        /// <param name="fromType"></param>
        /// <param name="ps"></param>
        /// <param name="key"></param>
        /// <returns></returns>
        public object Resolve(Type fromType, object[] ps = null, string key = "")
        {
            if (fromType == typeof(IContainer))
            {
                return this;
            }
            string k;
            DependencyDescriptor descriptor;
            if (fromType.IsGenericType)
            {
                var type = fromType.GetGenericTypeDefinition();
                k = $"{type.FullName}{key}";
                if (this.m_registrations.TryGetValue(k, out descriptor))
                {
                    if (descriptor.ImplementationFactory != null)
                    {
                        return descriptor.ImplementationFactory.Invoke(this);
                    }
                    if (descriptor.Lifetime == Lifetime.Singleton)
                    {
                        if (descriptor.ToInstance != null)
                        {
                            return descriptor.ToInstance;
                        }
                        lock (descriptor)
                        {
                            return descriptor.ToInstance != null
                                ? descriptor.ToInstance
                                : descriptor.ToType.IsGenericType
                                ? (descriptor.ToInstance = this.Create(descriptor.ToType.MakeGenericType(fromType.GetGenericArguments()), ps))
                                : (descriptor.ToInstance = this.Create(descriptor.ToType, ps));
                        }
                    }
                    return descriptor.ToType.IsGenericType
                        ? this.Create(descriptor.ToType.MakeGenericType(fromType.GetGenericArguments()), ps)
                        : this.Create(descriptor.ToType, ps);
                }
            }
            k = $"{fromType.FullName}{key}";
            if (this.m_registrations.TryGetValue(k, out descriptor))
            {
                if (descriptor.ImplementationFactory != null)
                {
                    return descriptor.ImplementationFactory.Invoke(this);
                }
                if (descriptor.Lifetime == Lifetime.Singleton)
                {
                    if (descriptor.ToInstance != null)
                    {
                        return descriptor.ToInstance;
                    }
                    lock (descriptor)
                    {
                        return descriptor.ToInstance ?? (descriptor.ToInstance = this.Create(descriptor.ToType, ps));
                    }
                }
                return this.Create(descriptor.ToType, ps);
            }
            else
            {
                if (fromType.IsPrimitive || fromType == typeof(string))
                {
                    return default;
                }
                else
                {
                    throw new Exception(TouchSocketCoreResource.UnregisteredType.GetDescription(fromType));
                }
            }
        }

        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        /// <param name="descriptor"></param>
        /// <param name="key"></param>
        public void Unregister(DependencyDescriptor descriptor, string key = "")
        {
            var k = $"{descriptor.FromType.FullName}{key}";
            this.m_registrations.TryRemove(k, out _);
        }

        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        /// <param name="toType"></param>
        /// <param name="ops"></param>
        /// <returns></returns>
        private object Create(Type toType, object[] ops)
        {
            var ctor = toType.GetConstructors().FirstOrDefault(x => x.IsDefined(typeof(DependencyInjectAttribute), true));
            if (ctor is null)
            {
                //如果没有被特性标记，那就取构造函数参数最多的作为注入目标
                if (toType.GetConstructors().Length == 0)
                {
                    throw new Exception($"没有找到类型{toType.FullName}的公共构造函数。");
                }
                ctor = toType.GetConstructors().OrderByDescending(x => x.GetParameters().Length).First();
            }
            else
            {
                ops ??= ctor.GetCustomAttribute<DependencyInjectAttribute>().Ps;
            }

            DependencyTypeAttribute dependencyTypeAttribute = null;
            if (toType.IsDefined(typeof(DependencyTypeAttribute), true))
            {
                dependencyTypeAttribute = toType.GetCustomAttribute<DependencyTypeAttribute>();
            }

            var parameters = ctor.GetParameters();
            var ps = new object[parameters.Length];

            if (dependencyTypeAttribute == null || dependencyTypeAttribute.Type.HasFlag(DependencyType.Constructor))
            {
                for (var i = 0; i < parameters.Length; i++)
                {
                    if (ops != null && ops.Length - 1 >= i)
                    {
                        ps[i] = ops[i];
                    }
                    else
                    {
                        if (parameters[i].ParameterType.IsPrimitive || parameters[i].ParameterType == typeof(string))
                        {
                            ps[i] = parameters[i].HasDefaultValue ? parameters[i].DefaultValue : default;
                        }
                        else
                        {
                            if (parameters[i].IsDefined(typeof(DependencyParamterInjectAttribute), true))
                            {
                                var attribute = parameters[i].GetCustomAttribute<DependencyParamterInjectAttribute>();
                                var type = attribute.Type ?? parameters[i].ParameterType;
                                ps[i] = this.Resolve(type, attribute.Ps, attribute.Key);
                            }
                            else
                            {
                                ps[i] = this.Resolve(parameters[i].ParameterType, null);
                            }
                        }
                    }
                }
            }
            var instance = Activator.CreateInstance(toType, ps);

            if (dependencyTypeAttribute == null || dependencyTypeAttribute.Type.HasFlag(DependencyType.Property))
            {
                var propetys = toType.GetProperties().Where(x => x.IsDefined(typeof(DependencyInjectAttribute), true));
                foreach (var item in propetys)
                {
                    if (item.CanWrite)
                    {
                        object obj;
                        if (item.IsDefined(typeof(DependencyParamterInjectAttribute), true))
                        {
                            var attribute = item.GetCustomAttribute<DependencyParamterInjectAttribute>();
                            var type = attribute.Type ?? item.PropertyType;
                            obj = this.Resolve(type, attribute.Ps, attribute.Key);
                        }
                        else
                        {
                            obj = this.Resolve(item.PropertyType, null);
                        }
                        item.SetValue(instance, obj);
                    }
                }
            }

            if (dependencyTypeAttribute == null || dependencyTypeAttribute.Type.HasFlag(DependencyType.Method))
            {
                var methods = toType.GetMethods(BindingFlags.Default | BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public | BindingFlags.NonPublic).Where(x => x.IsDefined(typeof(DependencyInjectAttribute), true)).ToList();
                foreach (var item in methods)
                {
                    parameters = item.GetParameters();
                    ops = item.GetCustomAttribute<DependencyInjectAttribute>().Ps;
                    ps = new object[parameters.Length];
                    for (var i = 0; i < ps.Length; i++)
                    {
                        if (ops != null && ops.Length - 1 >= i)
                        {
                            ps[i] = ops[i];
                        }
                        else
                        {
                            if (parameters[i].ParameterType.IsPrimitive || parameters[i].ParameterType == typeof(string))
                            {
                                ps[i] = parameters[i].HasDefaultValue ? parameters[i].DefaultValue : default;
                            }
                            else
                            {
                                if (parameters[i].IsDefined(typeof(DependencyParamterInjectAttribute), true))
                                {
                                    var attribute = parameters[i].GetCustomAttribute<DependencyParamterInjectAttribute>();
                                    var type = attribute.Type ?? parameters[i].ParameterType;
                                    ps[i] = this.Resolve(type, attribute.Ps, attribute.Key);
                                }
                                else
                                {
                                    ps[i] = this.Resolve(parameters[i].ParameterType, null);
                                }
                            }
                        }
                    }
                    item.Invoke(instance, ps);
                }
            }
            return instance;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
    }
}