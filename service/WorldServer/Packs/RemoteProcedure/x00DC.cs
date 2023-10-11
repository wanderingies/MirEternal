#pragma warning disable CS8618

using TouchSocket.Core;
using WorldServer.Service;

namespace WorldServer.Packs.Protocol
{
    /// <summary>
    /// <para>QuestRewardCompletedPacket</para>
    /// <para>QuestRewardCompletedPacket</para>
    /// </summary>
    internal class x00DC : Package
    {
        #region public field

		public Int32 QuestId;
        #endregion

        #region public attribute

        public ushort Type => 0x00DC;
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

