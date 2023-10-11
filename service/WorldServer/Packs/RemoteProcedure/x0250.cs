#pragma warning disable CS8618

using TouchSocket.Core;
using WorldServer.Service;

namespace WorldServer.Packs.Protocol
{
    /// <summary>
    /// <para>GuildJoinMemberPacket</para>
    /// <para>GuildJoinMemberPacket</para>
    /// </summary>
    internal class x0250 : Package
    {
        #region public field

		public Int32 对象编号;
		public String 对象名字;
		public Byte 对象职位;
		public Byte 对象等级;
		public Byte 对象职业;
		public Byte CurrentMap;
        #endregion

        #region public attribute

        public ushort Type => 0x0250;
        public ushort Size => 54;        
        #endregion
        
        #region private field


        #endregion

        public ByteBlock Marshal(ByteBlock byteBlock)
        {
			byteBlock.Write(对象编号);
			byteBlock.Write(对象名字);
			byteBlock.Write(对象职位);
			byteBlock.Write(对象等级);
			byteBlock.Write(对象职业);
			byteBlock.Write(CurrentMap);
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

