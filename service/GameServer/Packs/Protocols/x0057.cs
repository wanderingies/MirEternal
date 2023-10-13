#pragma warning disable CS8618

using TouchSocket.Core;
using GameServer.Service;

namespace GameServer.Packs.Protocol
{
    /// <summary>
    /// <para>CharacterSynthesisItemPacket</para>
    /// <para>CharacterSynthesisItemPacket</para>
    /// </summary>
    internal class x0057 : Package
    {
        #region public

		public Byte Id;
        #endregion

        #region marshal


        #endregion

        #region attribute

        public ushort Type => 0x0057;
        public ushort Size => 6;     
        public ushort rSize => 0;
        #endregion
        
        public x0057() 
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
			Id = byteBlock.ReadByte();
			return byteBlock;
        }

        public void Process(GameSession gameSession)
        {
            throw new NotImplementedException();
        }
    }
}

