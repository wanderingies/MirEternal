using System;

namespace SqlHelper.QueryBuilder.Components.WhereQuery
{
    [Serializable]
    public class WhereQueryNotLike : WhereQueryNot<WhereQueryLike>
    {
        public WhereQueryNotLike(string column, string value) : base(new WhereQueryLike(column, value))
        {
        }
    }
}
