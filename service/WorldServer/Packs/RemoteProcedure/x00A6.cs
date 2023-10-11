#pragma warning disable CS8618

using TouchSocket.Core;
using WorldServer.Service;

namespace WorldServer.Packs.Protocol
{
    /// <summary>
    /// <para>ClearGuildInfoPacket</para>
    /// <para>CompleteQuestPacket</para>
    /// </summary>
    internal class x00A6 : Package
    {
        #region public field

		public Int32 QuestId;
        #endregion

        #region public attribute

        public ushort Type => 0x00A6;
        public ushort Size => 6;        
        #endregion
        
        #region private field


        #endregion

        public ByteBlock Marshal(ByteBlock byteBlock)
        {
			byteBlock.Write(QuestId);
            return byteBlock;
        }

        public ByteBlock UnMarshal(ByteBlock byteBlock)
        {
            return byteBlock;
        }

        public void Process(WorldSession session)
        {
            
        }
    }
}

