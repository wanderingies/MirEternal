#pragma warning disable CS8618

using TouchSocket.Core;
using GameServer.Service;

namespace GameServer.Packs.Protocol
{
    /// <summary>
    /// <para>玩家同意交易</para>
    /// <para>货币描述</para>
    /// </summary>
    internal class x0094 : Package
    {
        #region public

		public Int32 对象编号;
        #endregion

        #region marshal

        public Byte U1;
        public byte[] CurrencyInfo;
        #endregion

        #region attribute

        public ushort Type => 0x0094;
        public ushort Size => 6;     
        public ushort rSize => 0;
        #endregion
        
        public x0094() 
        {
        }

        #region private


        #endregion

        public ByteBlock Marshal(ByteBlock byteBlock)
        {
            byteBlock.Write(U1);
            byteBlock.Write(CurrencyInfo);
            return byteBlock;
        }

        public ByteBlock UnMarshal(ByteBlock byteBlock)
        {
			对象编号 = byteBlock.ReadInt32();
			return byteBlock;
        }

        public void Process(GameSession gameSession)
        {
            throw new NotImplementedException();
        }
    }
}

