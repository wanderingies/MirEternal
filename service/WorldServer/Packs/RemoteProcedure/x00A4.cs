#pragma warning disable CS8618

using TouchSocket.Core;
using WorldServer.Service;

namespace WorldServer.Packs.Protocol
{
    /// <summary>
    /// <para>AcceptQuestPacket</para>
    /// <para>AcceptQuestPacket</para>
    /// </summary>
    internal class x00A4 : Package
    {
        #region public field

		public Int32 QuestId;
		public byte[] Quest;
        #endregion

        #region public attribute

        public ushort Type => 0x00A4;
        public ushort Size => 6;        
        #endregion
        
        #region private field


        #endregion

        public ByteBlock Marshal(ByteBlock byteBlock)
        {
			byteBlock.Write(QuestId);
			byteBlock.Write(Quest);
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

