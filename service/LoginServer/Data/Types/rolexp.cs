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

        [Column("roleid")]
        public int RoleId { get; set; }

        [Column("pklevel")]
        public int PkLevel { get; set; } = 0;

        [Column("attack")]
        public byte Attack { get; set; } = 0;

        [Column("backpack")]
        public int Backpack { get; set; } = -1;
        [Column("backpacksize")]
        public byte BackpackSize { get; set; } = 32;
        [Column("warehouse")]
        public int Warehouse { get; set; } = -1;
        [Column("warehousesize")]
        public byte WarehouseSize { get; set; } = 72;
        [Column("extrabackpack")]
        public int ExtraBackPack { get; set; } = -1;
        [Column("extrabackpacksize")]
        public byte ExtraBackpackSize { get; set; } = 144;
    }
}
