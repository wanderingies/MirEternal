using SqlHelper.DataBase;
using SqlHelper.QueryBuilder;

namespace SqlHelper.Entity
{
    public class ReplaceEntity
    {
        public static void Replace<T>(string connectionString, T entity) where T : new()
        {
            var replaceBuilder = new ReplaceQueryBuilder()
                .WithFields(EntityFactory.GetFieldsWithValues(entity, false));

            var query = replaceBuilder.Build<T>();
            DataBaseDataReader.ExecuteNonQuery(connectionString, query);
        }
    }
}
