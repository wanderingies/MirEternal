#pragma warning disable CS8618

using TouchSocket.Core;
using GameServer.Service;

namespace GameServer.Packs.Protocols
{
    /// <summary>
    /// <para>AcceptRewardPacket</para>
    /// <para>AcceptRewardPacket</para>
    /// </summary>
    internal class x009D : Package
    {
        #region public

        public int QuestId;
        #endregion

        #region marshal


        #endregion

        #region attribute

        public ushort Type => 0x009D;
        public ushort Size => 6;
        public ushort rSize => 0;
        #endregion

        public x009D()
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
            QuestId = byteBlock.ReadInt32();
            return byteBlock;
        }

        public void Process(GameSession gameSession)
        {
            throw new NotImplementedException();
        }
    }
}

