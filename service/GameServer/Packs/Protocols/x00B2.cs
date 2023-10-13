#pragma warning disable CS8618

using TouchSocket.Core;
using GameServer.Service;

namespace GameServer.Packs.Protocols
{
    /// <summary>
    /// <para>QueryGuildBattleHistoryPacket</para>
    /// <para>QueryGuildBattleHistoryPacket</para>
    /// </summary>
    internal class x00B2 : Package
    {
        #region public

        public byte PetMode;
        #endregion

        #region marshal


        #endregion

        #region attribute

        public ushort Type => 0x00B2;
        public ushort Size => 3;
        public ushort rSize => 0;
        #endregion

        public x00B2()
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
            PetMode = byteBlock.ReadByte();
            return byteBlock;
        }

        public void Process(GameSession gameSession)
        {
            throw new NotImplementedException();
        }
    }
}

