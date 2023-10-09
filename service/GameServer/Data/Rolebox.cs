#pragma warning disable CS8618

using GameServer.Data.Types;
using GameServer.Utility;

namespace GameServer.Data
{
    internal class Rolebox
    {
        public Rolebox()
        {
            sqlite_role = new Sqlitehelper<Role>();
            sqlite_rolexp = new Sqlitehelper<Rolexp>();
            Instance = this;
        }

        public Sqlitehelper<Role> sqlite_role;
        public Sqlitehelper<Rolexp> sqlite_rolexp;
        public static Rolebox Instance { get; private set; }

        public Role GetRole(int id)
        {
            var sql = $"SELECT * FROM [role] WHERE id={id}";
            return sqlite_role.GetConnection.FindWithQuery<Role>(sql);
        }

        public Rolexp GetRolexp(int id)
        {
            var sql = $"SELECT * FROM [rolexp] WHERE roleid={id}";
            return sqlite_rolexp.GetConnection.FindWithQuery<Rolexp>(sql);
        }
    }
}
