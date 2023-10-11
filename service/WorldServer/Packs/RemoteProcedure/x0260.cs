#pragma warning disable CS8618

using TouchSocket.Core;
using WorldServer.Service;

namespace WorldServer.Packs.Protocol
{
    /// <summary>
    /// <para>AddDiplomaticAnnouncementPacket</para>
    /// <para>AddDiplomaticAnnouncementPacket</para>
    /// </summary>
    internal class x0260 : Package
    {
        #region public field

		public Byte 外交类型;
		public Int32 行会编号;
		public Int32 外交时间;
		public Byte 行会等级;
		public Byte 行会人数;
		public String GuildName;
        #endregion

        #region public attribute

        public ushort Type => 0x0260;
        public ushort Size => 38;        
        #endregion
        
        #region private field


        #endregion

        public ByteBlock Marshal(ByteBlock byteBlock)
        {
			byteBlock.Write(外交类型);
			byteBlock.Write(行会编号);
			byteBlock.Write(外交时间);
			byteBlock.Write(行会等级);
			byteBlock.Write(行会人数);
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

