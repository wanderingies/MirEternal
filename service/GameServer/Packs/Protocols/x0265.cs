#pragma warning disable CS8618

using TouchSocket.Core;
using GameServer.Service;

namespace GameServer.Packs.Protocol
{
    /// <summary>
    /// <para>购买玛法特权</para>
    /// <para>购买玛法特权</para>
    /// </summary>
    internal class x0265 : Package
    {
        #region public

		public Byte 特权类型;
		public Byte 购买数量;
        #endregion

        #region marshal


        #endregion

        #region attribute

        public ushort Type => 0x0265;
        public ushort Size => 4;     
        public ushort rSize => 0;
        #endregion
        
        public x0265() 
        {
        }

        #region private


        #endregion

        public ByteBlock Marshal(ByteBlock byteBlock)
        {
            throw new NotImplementedException();
        }

        public ByteBlock UnMarshal(ByteBlock byteBlock)
        {
			特权类型 = byteBlock.ReadByte();
			购买数量 = byteBlock.ReadByte();
			return byteBlock;
        }

        public void Process(GameSession gameSession)
        {
            throw new NotImplementedException();
        }
    }
}

