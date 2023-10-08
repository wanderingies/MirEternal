#pragma warning disable CS0649
#pragma warning disable CS8618

using SQLite;

namespace GameServer.Data.Types
{
    /// <summary>
    /// 用户
    /// </summary>
    [Table("user")]
    public class User
    {
        /// <summary>
        /// 编号
        /// </summary>
        [AutoIncrement, PrimaryKey, Unique]
        [Column("id")]
        public int Id { get; set; }

        /// <summary>
        /// 名称
        /// </summary>
        [Column("name")]
        public string Name { get; set; }

        /// <summary>
        /// 令牌
        /// </summary>
        [Column("ticket")]
        public string Ticket { get; set; }
        /// <summary>
        /// 密码
        /// </summary>
        [Column("passwd")]
        public string Passwd { get; set; } = String.Empty;

        /// <summary>
        /// 邮箱
        /// </summary>
        [Column("email")]
        public string Email { get; set; } = String.Empty;

        /// <summary>
        /// 创建日期
        /// </summary>
        [Column("createdtime")]
        public DateTime CreatedTime { get; set; } = DateTime.Now;

        /// <summary>
        /// 封禁日期
        /// </summary>
        [Column("forbidtime")]
        public DateTime ForbidTime { get; set; } = DateTime.Now;

        /// <summary>
        /// 用户元宝
        /// </summary>
        [Column("ingots")]
        public long Ingots { get; set; }

        /// <summary>
        /// 当前状态
        /// </summary>
        //[Column("gamestate")]
        //public Gamestate Gamestate { get; set; } = Gamestate.StartingSessionScene;

        /// <summary>
        /// 删除日期
        /// </summary>
        //public DateTime DeleteTime { get; set; } = DateTime.Now;

        /// <summary>
        /// 角色列表
        /// </summary>
        /*public List<int> RoleList { get; set; } = new List<int>();

        /// <summary>
        /// 角色冻结列表
        /// </summary>
        public List<int> RoleFreeze { get; set; } = new List<int>();

        /// <summary>
        /// 角色删除列表
        /// </summary>
        public List<int> RoleDelete { get; set; } = new List<int>();*/
    }
}
