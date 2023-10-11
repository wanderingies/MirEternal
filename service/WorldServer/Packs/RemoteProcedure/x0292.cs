#pragma warning disable CS8618

using TouchSocket.Core;
using WorldServer.Service;

namespace WorldServer.Packs.Protocol
{
    /// <summary>
    /// <para>购买珍宝商品</para>
    /// <para>购入珍宝商品</para>
    /// </summary>
    internal class x0292 : Package
    {
        #region public field

		public Int32 Id;
		public Int32 购买数量;
        #endregion

        #region public attribute

        public ushort Type => 0x0292;
        public ushort Size => 10;        
        #endregion
        
        #region private field


        #endregion

        public ByteBlock Marshal(ByteBlock byteBlock)
        {
			byteBlock.Write(Id);
			byteBlock.Write(购买数量);
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

