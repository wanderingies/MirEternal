#pragma warning disable CS8618

using TouchSocket.Core;
using WorldServer.Service;

namespace WorldServer.Packs.Protocol
{
    /// <summary>
    /// <para>RemoveStallItemsPacket</para>
    /// <para>RemoveStallItemsPacket</para>
    /// </summary>
    internal class x009E : Package
    {
        #region public field

		public Byte 取回位置;
        #endregion

        #region public attribute

        public ushort Type => 0x009E;
        public ushort Size => 3;        
        #endregion
        
        #region private field


        #endregion

        public ByteBlock Marshal(ByteBlock byteBlock)
        {
			byteBlock.Write(取回位置);
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

