#pragma warning disable CS8618

using TouchSocket.Core;
using WorldServer.Service;

namespace WorldServer.Packs.Protocol
{
    /// <summary>
    /// <para>PutInTradingCoins</para>
    /// <para>PutInTradingCoins</para>
    /// </summary>
    internal class x00D9 : Package
    {
        #region public field

		public Int32 对象编号;
		public Int32 NumberGoldCoins;
        #endregion

        #region public attribute

        public ushort Type => 0x00D9;
        public ushort Size => 10;        
        #endregion
        
        #region private field


        #endregion

        public ByteBlock Marshal(ByteBlock byteBlock)
        {
			byteBlock.Write(对象编号);
			byteBlock.Write(NumberGoldCoins);
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

