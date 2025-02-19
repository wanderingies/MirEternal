﻿using System;
using System.Collections.Generic;
using System.Text;

namespace SqlHelper.Attributes
{
    [AttributeUsage(AttributeTargets.Property)]
    public class ForeignKeyIdAttribute : Attribute
    {
        public Type ForeignType;

        public ForeignKeyIdAttribute(Type foreignType)
        {
            ForeignType = foreignType;
        }
    }
}
