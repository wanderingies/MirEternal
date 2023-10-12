#pragma warning disable CS8618

using TouchSocket.Core;
using WorldServer.Service;

namespace WorldServer.Packs.Protocol
{
    /// <summary>
    /// <para>ReceiveChatMessagesNearbyPacket(附近)</para>
    /// <para>ReceiveChatMessagesNearbyPacket</para>
    /// </summary>
    internal class x00B3 : Package
    {
        #region public field

		public byte[] 字节描述;
        #endregion

        #region public attribute

        public ushort Type => 0x00B3;
        public ushort Size => 0;        
        #endregion
        
        #region private field


        #endregion

        public ByteBlock Marshal(ByteBlock byteBlock)
        {
			byteBlock.Write(字节描述);
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

