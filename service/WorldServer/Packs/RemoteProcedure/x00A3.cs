#pragma warning disable CS8618

using TouchSocket.Core;
using WorldServer.Service;

namespace WorldServer.Packs.Protocol
{
    /// <summary>
    /// <para>StallItemsSoldPacket</para>
    /// <para>StallItemsSoldPacket</para>
    /// </summary>
    internal class x00A3 : Package
    {
        #region public field

		public Byte 物品位置;
		public Int32 售出数量;
		public Int32 售出收益;
        #endregion

        #region public attribute

        public ushort Type => 0x00A3;
        public ushort Size => 11;        
        #endregion
        
        #region private field


        #endregion

        public ByteBlock Marshal(ByteBlock byteBlock)
        {
			byteBlock.Write(物品位置);
			byteBlock.Write(售出数量);
			byteBlock.Write(售出收益);
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

