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
        public int RoleId {  get; set; }

        [Column("pklevel")]
        public int PkLevel {  get; set; }

        [Column("attack")]
        public byte Attack { get; set; } = 0;

        [Column("backpack")]
        public int Backpack { get; set; }
        [Column("backpacksize")]
        public byte BackpackSize { get; set; } = 32;
        [Column("warehouse")]
        public int Warehouse {  get; set; }
        [Column("warehousesize")]
        public byte WarehouseSize { get; set; } = 72;
        [Column("extrabackpack")]
        public int ExtraBackPack {  get; set; }
        [Column("extrabackpacksize")]
        public byte ExtraBackpackSize { get; set; } = 144;

        [Column("streetstallstate")]
        public byte StreetStallState { get; set; } = 0;
        [Column("streetstallname")]
        public string StreetStallName { get; set; }
    }
}
