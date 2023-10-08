#pragma warning disable CS8618

using SQLite;

namespace LoginServer.Data.Types
{
    [Table("userole")]
    public class Userole
    {
        /// <summary>
        /// 编号
        /// </summary>
        [AutoIncrement, PrimaryKey, Unique]
        [Column("id")]
        public int Id { get; set; }

        /// <summary>
        /// 账户编号
        /// </summary>
        [Column("userid")]
        public string Userid { get; set; }

        /// <summary>
        /// 角色编号
        /// </summary>
        [Column("roleid")]
        public int RoleId { get; set; }

        /// <summary>
        /// 角色名称
        /// </summary>
        [Column("rolename")]
        public string RoleName { get; set; }

        [Column("freezetime")]
        public DateTime FreezeTime { get; set; } = DateTime.Now;

        [Column("deletetime")]
        public DateTime DeleteTime { get; set; } = default;
    }
}
