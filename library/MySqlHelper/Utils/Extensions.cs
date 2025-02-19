﻿using System;
using System.Collections.Generic;
using System.Text;

namespace SqlHelper.Utils
{
    public static class Extensions
    {
        public static bool IsList(this Type type)
        {
            return type.IsGenericType && type.GetGenericTypeDefinition().IsAssignableFrom(typeof(List<>));
        }
    }
}
