#pragma warning disable CS8618

using SQLite;

namespace GameServer.Data.Types
{
    [Table("role")]
    public class Role
    {
        /// <summary>
        /// 编号
        /// </summary>
        [AutoIncrement, PrimaryKey, Unique]
        [Column("id")]
        public int Id { get; set; }

        [Column("name")]
        public string Name { get; set; }

        [Column("race")]
        public byte Race {  get; set; }
        [Column("gender")]
        public byte Gender { get; set; }
        [Column("hairstyle")]
        public byte HairStyle { get; set; }
        [Column("haircolor")]
        public byte HairColor {  get; set; }
        [Column("facestyle")]
        public byte FaceStyle {  get; set; }

        [Column("level")]
        public byte Level {  get; set; }
        [Column("hp")]
        public int HP {  get; set; }
        [Column("mp")]
        public int MP {  get; set; }
        [Column("map")]
        public int Map {  get; set; }

        [Column("createtime")]
        public DateTime CreateTime { get; set; } = DateTime.Now;

        [Column("lasttime")]
        public DateTime LastTime {  get; set; } = default;

        [Column("freezetime")]
        public DateTime FreezeTime { get; set; } = default;

        [Column("deletetime")]
        public DateTime DeleteTime { get; set; } = default;
    }
}
