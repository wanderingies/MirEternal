﻿using System;

namespace SqlHelper.QueryBuilder.Components.WhereQuery
{
    [Serializable]
    public class WhereQueryNotIn : WhereQueryNot<WhereQueryIn>
    {
        public WhereQueryNotIn(string column, params object[] inValues) : base(new WhereQueryIn(column, inValues))
        {
        }
    }
}
