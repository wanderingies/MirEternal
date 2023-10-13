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
        #region public

		public Int32 QuestId;
        #endregion

        #region marshal


        #endregion

        #region attribute

        public ushort Type => 0x00EB;
        public ushort Size => 6;     
        public ushort rSize => 0;
        #endregion
        
        public x00EB() 
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

