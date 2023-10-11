#pragma warning disable CS8618

using TouchSocket.Core;
using WorldServer.Service;

namespace WorldServer.Packs.Protocol
{
    /// <summary>
    /// <para>RequestTreasureDataPacket</para>
    /// <para>同步珍宝数据</para>
    /// </summary>
    internal class x0291 : Package
    {
        #region public field

		public Int32 版本编号;
		public Int32 商品数量;
        #endregion

        #region public attribute

        public ushort Type => 0x0291;
        public ushort Size => 0;        
        #endregion
        
        #region private field


        #endregion

        public ByteBlock Marshal(ByteBlock byteBlock)
        {
			byteBlock.Write(版本编号);
			byteBlock.Write(商品数量);
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

