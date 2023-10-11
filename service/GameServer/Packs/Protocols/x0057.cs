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
        #region public field

		public Byte Id;
        #endregion

        #region public attribute

        public ushort Type => 0x0057;
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
			Id = byteBlock.ReadByte();
            return byteBlock;
        }

        public void Process(GameSession session)
        {
            
        }
    }
}

