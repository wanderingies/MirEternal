using System;

namespace SqlHelper.QueryBuilder.Components.WhereQuery
{
    [Serializable]
    public class WhereQueryLowerThanOrEqual : WhereQueryInequality
    {
        public WhereQueryLowerThanOrEqual(string column, object value) : base(column, "<=", value)
        {
        }
    }
}