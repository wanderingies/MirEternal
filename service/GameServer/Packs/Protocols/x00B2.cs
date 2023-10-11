#pragma warning disable CS8618

using TouchSocket.Core;
using GameServer.Service;

namespace GameServer.Packs.Protocol
{
    /// <summary>
    /// <para>QueryGuildBattleHistoryPacket</para>
    /// <para>QueryGuildBattleHistoryPacket</para>
    /// </summary>
    internal class x00B2 : Package
    {
        #region public field

		public Byte PetMode;
        #endregion

        #region public attribute

        public ushort Type => 0x00B2;
        public ushort Size => 3;        
        #endregion
        
        #region private field


        #endregion

        public ByteBlock Marshal(ByteBlock byteBlock)
        {
            return byteBlock;
        }

        public ByteBlock UnMarshal(ByteBlock byteBlock)
        {
			PetMode = byteBlock.ReadByte();
            return byteBlock;
        }

        public void Process(GameSession session)
        {
            
        }
    }
}

