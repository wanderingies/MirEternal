﻿using System;

namespace SqlHelper.QueryBuilder.Components.WhereQuery
{
    [Serializable]
    public class WhereQueryGreaterThan : WhereQueryInequality
    {
        public WhereQueryGreaterThan(string column, object value) : base(column, ">", value)
        {
        }
    }
}
