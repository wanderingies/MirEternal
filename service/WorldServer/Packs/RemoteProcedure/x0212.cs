#pragma warning disable CS8618

using TouchSocket.Core;
using WorldServer.Service;

namespace WorldServer.Packs.Protocol
{
    /// <summary>
    /// <para>SyncFriendsListPacket</para>
    /// <para>SyncFriendsListPacket</para>
    /// </summary>
    internal class x0212 : Package
    {
        #region public field

		public byte[] 字节描述;
        #endregion

        #region public attribute

        public ushort Type => 0x0212;
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

