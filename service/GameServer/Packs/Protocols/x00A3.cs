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
        #region public field

		public Int32 NumberGoldCoins;
        #endregion

        #region public attribute

        public ushort Type => 0x00A3;
        public ushort Size => 6;        
        #endregion
        
        #region private field


        #endregion

        public ByteBlock Marshal(ByteBlock byteBlock)
        {
            return byteBlock;
        }

        public ByteBlock UnMarshal(ByteBlock byteBlock)
        {
			NumberGoldCoins = byteBlock.ReadInt32();
            return byteBlock;
        }

        public void Process(GameSession session)
        {
            
        }
    }
}

