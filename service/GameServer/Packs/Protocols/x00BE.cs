#pragma warning disable CS8618

using TouchSocket.Core;
using GameServer.Service;

namespace GameServer.Packs.Protocol
{
    /// <summary>
    /// <para>更改PetMode</para>
    /// <para>更改PetMode</para>
    /// </summary>
    internal class x00BE : Package
    {
        #region public

		public Byte PetMode;
        #endregion

        #region marshal


        #endregion

        #region attribute

        public ushort Type => 0x00BE;
        public ushort Size => 3;     
        public ushort rSize => 0;
        #endregion
        
        public x00BE() 
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
			PetMode = byteBlock.ReadByte();
			return byteBlock;
        }

        public void Process(GameSession gameSession)
        {
            throw new NotImplementedException();
        }
    }
}

