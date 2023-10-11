#pragma warning disable CS8618

using TouchSocket.Core;
using GameServer.Service;

namespace GameServer.Packs.Protocol
{
    /// <summary>
    /// <para>AcceptRewardPacket</para>
    /// <para>AcceptRewardPacket</para>
    /// </summary>
    internal class x009D : Package
    {
        #region public field

		public Int32 QuestId;
        #endregion

        #region public attribute

        public ushort Type => 0x009D;
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
			QuestId = byteBlock.ReadInt32();
            return byteBlock;
        }

        public void Process(GameSession session)
        {
            
        }
    }
}

