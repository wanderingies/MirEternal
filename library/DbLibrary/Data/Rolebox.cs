#pragma warning disable CS0649
#pragma warning disable CS8618

using DbLibrary.Data.Types;
using DbLibrary.Utility;

namespace DbLibrary.Data
{
    public class Rolebox
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
    }
}
