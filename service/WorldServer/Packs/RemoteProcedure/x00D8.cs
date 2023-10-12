#pragma warning disable CS8618

using TouchSocket.Core;
using WorldServer.Service;

namespace WorldServer.Packs.Protocol
{
    /// <summary>
    /// <para>PutInTradeItemsPacket</para>
    /// <para>PutInTradeItemsPacket</para>
    /// </summary>
    internal class x00D8 : Package
    {
        #region public field

		public Int32 对象编号;
		public Byte 放入位置;
		public Byte 放入物品;
		public byte[] 物品描述;
        #endregion

        #region public attribute

        public ushort Type => 0x00D8;
        public ushort Size => 0;        
        #endregion
        
        #region private field


        #endregion

        public ByteBlock Marshal(ByteBlock byteBlock)
        {
			byteBlock.Write(对象编号);
			byteBlock.Write(放入位置);
			byteBlock.Write(放入物品);
			byteBlock.Write(物品描述);
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

