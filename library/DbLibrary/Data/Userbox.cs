#pragma warning disable CS0649
#pragma warning disable CS8618

using DbLibrary.Data.Types;
using DbLibrary.Utility;

namespace DbLibrary.Data
{
    public class Userbox
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
    }
}
