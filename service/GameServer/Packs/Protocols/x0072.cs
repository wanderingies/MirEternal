#pragma warning disable CS8618

using TouchSocket.Core;
using GameServer.Service;

namespace GameServer.Packs.Protocols
{
    /// <summary>
    /// <para>玩家完成任务</para>
    /// <para>PlayerCompleteQuestPacket</para>
    /// </summary>
    internal class x0072 : Package
    {
        #region public

        public int QuestId;
        public int Unknown;
        #endregion

        #region marshal


        #endregion

        #region attribute

        public ushort Type => 0x0072;
        public ushort Size => 10;
        public ushort rSize => 0;
        #endregion

        public x0072()
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
            Unknown = byteBlock.ReadInt32();
            return byteBlock;
        }

        public void Process(GameSession gameSession)
        {
            throw new NotImplementedException();
        }
    }
}

