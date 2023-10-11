#pragma warning disable CS8618

using TouchSocket.Core;
using GameServer.Service;

namespace GameServer.Packs.Protocol
{
    /// <summary>
    /// <para>玩家完成任务</para>
    /// <para>PlayerCompleteQuestPacket</para>
    /// </summary>
    internal class x0072 : Package
    {
        #region public field

		public Int32 QuestId;
		public Int32 Unknown;
        #endregion

        #region public attribute

        public ushort Type => 0x0072;
        public ushort Size => 10;        
        #endregion
        
        #region private field


        #endregion

        public ByteBlock Marshal(ByteBlock byteBlock)
        {
            return byteBlock;
        }

        public ByteBlock UnMarshal(ByteBlock byteBlock)
        {
			QuestId = byteBlock.ReadInt32();
			Unknown = byteBlock.ReadInt32();
            return byteBlock;
        }

        public void Process(GameSession session)
        {
            
        }
    }
}

