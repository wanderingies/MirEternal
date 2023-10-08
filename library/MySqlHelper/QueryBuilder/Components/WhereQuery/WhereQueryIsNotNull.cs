using System;
using System.Collections.Generic;
using System.Text;

namespace SqlHelper.QueryBuilder.Components.WhereQuery
{
    [Serializable]
    public class WhereQueryIsNotNull : WhereQueryCondition
    {
        public WhereQueryIsNotNull(string column)
            : base(column, string.Empty)
        { }

        internal override string GenerateCondition()
        {
            return $"NOT {PrependTable()}{Column} IS NULL";
        }
    }
}
