#pragma warning disable CS8618

using GameServer.Data.Types;
using LoginServer.Data.Types;
using LoginServer.Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoginServer.Data
{
    internal class Rolebox
    {
        public Rolebox()
        {
            sqlite_role = new Sqlitehelper<Role>();
            sqlite_userole = new Sqlitehelper<Userole>();
            Instance = this;
        }

        public Sqlitehelper<Role> sqlite_role;
        public Sqlitehelper<Userole> sqlite_userole;
        public static Rolebox Instance { get; private set; }

        public Role GetRole(int id)
        {
            var sql = $"SELECT * FROM [role] WHERE id={id}";
            return sqlite_role.GetConnection.FindWithQuery<Role>(sql);
        }

        public Role GetRole(string name)
        {
            var sql = $"SELECT * FROM [role] WHERE name='{name}'";
            return sqlite_role.GetConnection.FindWithQuery<Role>(sql);
        }

        public List<Role> GetRoles(int id)
        {
            var sql = $"SELECT * FROM [role] WHERE id={id}";
            return sqlite_role.GetConnection.Query<Role>(sql);
        }

        
    }
}
