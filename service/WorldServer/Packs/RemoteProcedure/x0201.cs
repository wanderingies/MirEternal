#pragma warning disable CS8618

using TouchSocket.Core;
using WorldServer.Service;

namespace WorldServer.Packs.Protocol
{
    /// <summary>
    /// <para>同步角色信息</para>
    /// <para>同步角色信息</para>
    /// </summary>
    internal class x0201 : Package
    {
        #region public field

		public Int32 对象编号;
		public String 对象名字;
		public Byte 对象职业;
		public Byte 对象性别;
		public Byte 会员等级;
		public String GuildName;
        #endregion

        #region public attribute

        public ushort Type => 0x0201;
        public ushort Size => 66;        
        #endregion
        
        #region private field


        #endregion

        public ByteBlock Marshal(ByteBlock byteBlock)
        {
			byteBlock.Write(对象编号);
			byteBlock.Write(对象名字);
			byteBlock.Write(对象职业);
			byteBlock.Write(对象性别);
			byteBlock.Write(会员等级);
			byteBlock.Write(GuildName);
            return byteBlock;
        }

        public ByteBlock UnMarshal(ByteBlock byteBlock)
        {
            return byteBlock;
        }

        public void Process(WorldSession session)
        {
            
        }
    }
}

