using System;
using SqlHelper.Utils;

namespace SqlHelper.QueryBuilder.Components.WhereQuery
{
    [Serializable]
    public class WhereQueryLike : WhereQueryCondition
    {
        public WhereQueryLike(string column, string value) : base(column, value)
        {
        }

        internal override string GenerateCondition()
        {
            return $"{PrependTable()}{Column} LIKE {ValueFormat.GenerateFormattedValueForQuery(Value)}";
        }
    }
}
