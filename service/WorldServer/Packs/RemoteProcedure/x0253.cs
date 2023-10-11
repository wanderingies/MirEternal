#pragma warning disable CS8618

using TouchSocket.Core;
using WorldServer.Service;

namespace WorldServer.Packs.Protocol
{
    /// <summary>
    /// <para>GuildInvitationAnswerPacket</para>
    /// <para>GuildInvitationAnswerPacket</para>
    /// </summary>
    internal class x0253 : Package
    {
        #region public field

		public Byte 应答类型;
		public String 对象名字;
        #endregion

        #region public attribute

        public ushort Type => 0x0253;
        public ushort Size => 35;        
        #endregion
        
        #region private field


        #endregion

        public ByteBlock Marshal(ByteBlock byteBlock)
        {
			byteBlock.Write(应答类型);
			byteBlock.Write(对象名字);
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

