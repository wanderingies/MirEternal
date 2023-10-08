using System;

namespace SqlHelper.QueryBuilder.Components.WhereQuery
{
    [Serializable]
    public class WhereQueryLowerThan : WhereQueryInequality
    {
        public WhereQueryLowerThan(string column, object value) : base(column, "<", value)
        {
        }
    }
}