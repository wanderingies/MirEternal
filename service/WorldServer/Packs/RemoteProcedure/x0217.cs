#pragma warning disable CS8618

using TouchSocket.Core;
using WorldServer.Service;

namespace WorldServer.Packs.Protocol
{
    /// <summary>
    /// <para>OtherPartyUnfollowsPacket</para>
    /// <para>OtherPartyUnfollowsPacket</para>
    /// </summary>
    internal class x0217 : Package
    {
        #region public field

		public Int32 对象编号;
		public String 对象名字;
        #endregion

        #region public attribute

        public ushort Type => 0x0217;
        public ushort Size => 38;        
        #endregion
        
        #region private field


        #endregion

        public ByteBlock Marshal(ByteBlock byteBlock)
        {
			byteBlock.Write(对象编号);
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

