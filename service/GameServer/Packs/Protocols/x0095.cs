#pragma warning disable CS8618

using TouchSocket.Core;
using GameServer.Service;

namespace GameServer.Packs.Protocol
{
    /// <summary>
    /// <para>玩家放入金币</para>
    /// <para>玩家放入金币</para>
    /// </summary>
    internal class x0095 : Package
    {
        #region public field

		public Int32 NumberGoldCoins;
        #endregion

        #region public attribute

        public ushort Type => 0x0095;
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

