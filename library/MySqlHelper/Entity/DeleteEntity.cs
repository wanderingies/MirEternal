using System;
using System.Collections.Generic;
using System.Linq;
using SqlHelper.Attributes;
using SqlHelper.DataBase;
using SqlHelper.QueryBuilder;
using SqlHelper.QueryBuilder.Components.WhereQuery;

namespace SqlHelper.Entity
{
    public static class DeleteEntity
    {
        public static void Delete<T>(string connectionString, T entity) where T : new()
        {
            var (condition, wheres) = KeyAttribute.GetKeysQueryWhere(entity);

            var deleteQueryBuilder = new DeleteQueryBuilder()
                .WithWhere(condition, wheres.ToArray());

            var query = deleteQueryBuilder.Build<T>();

            DataBaseDataReader.ExecuteNonQuery(connectionString, query);
        }
    }
}
