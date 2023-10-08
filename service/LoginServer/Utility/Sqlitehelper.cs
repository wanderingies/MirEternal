#pragma warning disable CS8604

using SQLite;

namespace LoginServer.Utility
{
    internal class Sqlitehelper<T> where T : new()
    {
        public string Datapath { get; set; } = Path.Combine("data", "data.db");

        public SQLiteConnection GetConnection => new SQLiteConnection(Datapath);

        public Sqlitehelper()
        {
            FileInfo fileInfo = new FileInfo(Datapath);
            if (!Directory.Exists(fileInfo.DirectoryName))
                Directory.CreateDirectory(fileInfo.DirectoryName);

            //if (File.Exists(fileInfo.FullName))
                GetConnection.CreateTable<T>();            
        }
    }
}
