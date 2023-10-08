#pragma warning disable CS8618

using SQLite;

namespace GameServer.Data.Types
{
    [Table("rolexp")]
    public class Rolexp
    {
        [AutoIncrement, PrimaryKey, Unique]
        [Column("id")]
        public int Id { get; set; }


    }
}
