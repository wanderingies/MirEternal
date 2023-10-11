#pragma warning disable CS8618

using TouchSocket.Core;
using WorldServer.Service;

namespace WorldServer.Packs.Protocol
{
    /// <summary>
    /// <para>InviteJoinPacket</para>
    /// <para>InviteJoinPacket</para>
    /// </summary>
    internal class x0252 : Package
    {
        #region public field

		public Int32 对象编号;
		public String 对象名字;
		public String GuildName;
        #endregion

        #region public attribute

        public ushort Type => 0x0252;
        public ushort Size => 63;        
        #endregion
        
        #region private field


        #endregion

        public ByteBlock Marshal(ByteBlock byteBlock)
        {
			byteBlock.Write(对象编号);
			byteBlock.Write(对象名字);
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

