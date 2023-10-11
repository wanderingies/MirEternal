#pragma warning disable CS8618

using TouchSocket.Core;
using GameServer.Service;

namespace GameServer.Packs.Protocol
{
    /// <summary>
    /// <para>QuestTeleportPacket</para>
    /// <para>QuestTeleportPacket</para>
    /// </summary>
    internal class x00EB : Package
    {
        #region public field

		public Int32 QuestId;
        #endregion

        #region public attribute

        public ushort Type => 0x00EB;
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

