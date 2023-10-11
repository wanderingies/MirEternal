#pragma warning disable CS8618

using TouchSocket.Core;
using GameServer.Service;

namespace GameServer.Packs.Protocol
{
    /// <summary>
    /// <para>购买珍宝商品</para>
    /// <para>购买珍宝商品</para>
    /// </summary>
    internal class x0258 : Package
    {
        #region public field

		public Int32 Id;
		public Int32 购买数量;
        #endregion

        #region public attribute

        public ushort Type => 0x0258;
        public ushort Size => 42;        
        #endregion
        
        #region private field


        #endregion

        public ByteBlock Marshal(ByteBlock byteBlock)
        {
            return byteBlock;
        }

        public ByteBlock UnMarshal(ByteBlock byteBlock)
        {
			Id = byteBlock.ReadInt32();
			购买数量 = byteBlock.ReadInt32();
            return byteBlock;
        }

        public void Process(GameSession session)
        {
            
        }
    }
}

