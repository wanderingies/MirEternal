#pragma warning disable CS8618

using TouchSocket.Core;
using WorldServer.Service;

namespace WorldServer.Packs.Protocol
{
    /// <summary>
    /// <para>购买摊位物品</para>
    /// <para>购入摊位物品</para>
    /// </summary>
    internal class x00A2 : Package
    {
        #region public field

		public Int32 对象编号;
		public Byte 物品位置;
		public Int32 剩余数量;
        #endregion

        #region public attribute

        public ushort Type => 0x00A2;
        public ushort Size => 11;        
        #endregion
        
        #region private field


        #endregion

        public ByteBlock Marshal(ByteBlock byteBlock)
        {
			byteBlock.Write(对象编号);
			byteBlock.Write(物品位置);
			byteBlock.Write(剩余数量);
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

