#pragma warning disable CS0649
#pragma warning disable CS8618

using GameServer.Data.Types;
using LoginServer.Data.Types;
using LoginServer.Utility;

namespace LoginServer.Data
{
    internal class Userbox
    {
        public Userbox()
        {
            sqlite_user = new Sqlitehelper<User>();
            sqlite_userole = new Sqlitehelper<Userole>();
            Instance = this;
        }

        public Sqlitehelper<User> sqlite_user;
        public Sqlitehelper<Userole> sqlite_userole;
        public static Userbox Instance { get; private set; }

        public User GetUser(int userid)
        {
            var sql = $"SELECT * FROM [user] WHERE id={userid}";
            return sqlite_user.GetConnection.FindWithQuery<User>(sql);
        }

        public User GetUser(string ticket)
        {
            var sql = $"SELECT * FROM [user] WHERE ticket='{ticket}'";
            return sqlite_user.GetConnection.FindWithQuery<User>(sql);
        }

        public int GetRoles()
        {
            var sql = $"SELECT * FROM [userole] WHERE";
            return sqlite_userole.GetConnection.Query<Userole>(sql).Count;
        }

        public Userole GetUserole(int roleid)
        {
            var sql = $"SELECT * FROM [userole] WHERE roleid={roleid}";
            return sqlite_userole.GetConnection.FindWithQuery<Userole>(sql);
        }

        public List<Userole> GetRoles(string userid)
        {
            var sql = $"SELECT * FROM [userole] WHERE userid='{userid}'";
            return sqlite_userole.GetConnection.Query<Userole>(sql);
        }

        public Userole GetRole(string name)
        {
            var sql = $"SELECT * FROM [userole] WHERE rolename='{name}'";
            return sqlite_userole.GetConnection.FindWithQuery<Userole>(sql);
        }

        public int SetUser(User user)
        {
            return sqlite_user.GetConnection.Insert(user);
        }

        public int SetUser(string name, string ticket)
        {
            var user = new User()
            {
                Name = name,
                Ticket = ticket
            };

            return SetUser(user);
        }
    }
}
