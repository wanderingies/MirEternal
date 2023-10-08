using System;

namespace SqlHelper.QueryBuilder.Components.WhereQuery
{
    [Serializable]
    public class WhereQueryGreaterThanOrEqual : WhereQueryInequality
    {
        public WhereQueryGreaterThanOrEqual(string column, object value) : base(column, ">=", value)
        {
        }
    }
}
