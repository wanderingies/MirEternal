#pragma warning disable CS8618

using TouchSocket.Core;
using WorldServer.Service;

namespace WorldServer.Packs.Protocol
{
    /// <summary>
    /// <para>货币数量变动</para>
    /// <para>货币数量变动</para>
    /// </summary>
    internal class x0095 : Package
    {
        #region public field

		public Byte CurrencyType;
		public Int32 货币数量;
        #endregion

        #region public attribute

        public ushort Type => 0x0095;
        public ushort Size => 30;        
        #endregion
        
        #region private field


        #endregion

        public ByteBlock Marshal(ByteBlock byteBlock)
        {
			byteBlock.Write(CurrencyType);
			byteBlock.Write(货币数量);
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

