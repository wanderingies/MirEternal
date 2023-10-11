#pragma warning disable CS8618

using TouchSocket.Core;
using WorldServer.Service;

namespace WorldServer.Packs.Protocol
{
    /// <summary>
    /// <para>GuildBanAnnouncementPacket</para>
    /// <para>GuildBanAnnouncementPacket</para>
    /// </summary>
    internal class x0256 : Package
    {
        #region public field

		public Int32 对象编号;
		public Byte 禁言状态;
        #endregion

        #region public attribute

        public ushort Type => 0x0256;
        public ushort Size => 7;        
        #endregion
        
        #region private field


        #endregion

        public ByteBlock Marshal(ByteBlock byteBlock)
        {
			byteBlock.Write(对象编号);
			byteBlock.Write(禁言状态);
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

