#pragma warning disable CS8618

using TouchSocket.Core;
using GameServer.Service;

namespace GameServer.Packs.Protocol
{
    /// <summary>
    /// <para>DonateGuildFundsPacket</para>
    /// <para>DonateGuildFundsPacket</para>
    /// </summary>
    internal class x00A3 : Package
    {
        #region public

		public Int32 NumberGoldCoins;
        #endregion

        #region marshal


        #endregion

        #region attribute

        public ushort Type => 0x00A3;
        public ushort Size => 6;     
        public ushort rSize => 0;
        #endregion
        
        public x00A3() 
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
			NumberGoldCoins = byteBlock.ReadInt32();
			return byteBlock;
        }

        public void Process(GameSession gameSession)
        {
            throw new NotImplementedException();
        }
    }
}

