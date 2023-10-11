#pragma warning disable CS8618

using TouchSocket.Core;
using WorldServer.Service;

namespace WorldServer.Packs.Protocol
{
    /// <summary>
    /// <para>AddStallItemsPacket</para>
    /// <para>AddStallItemsPacket</para>
    /// </summary>
    internal class x009D : Package
    {
        #region public field

		public Byte 放入位置;
		public Byte 背包类型;
		public Byte 物品位置;
		public UInt16 物品数量;
		public Int32 物品价格;
        #endregion

        #region public attribute

        public ushort Type => 0x009D;
        public ushort Size => 11;        
        #endregion
        
        #region private field


        #endregion

        public ByteBlock Marshal(ByteBlock byteBlock)
        {
			byteBlock.Write(放入位置);
			byteBlock.Write(背包类型);
			byteBlock.Write(物品位置);
			byteBlock.Write(物品数量);
			byteBlock.Write(物品价格);
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

