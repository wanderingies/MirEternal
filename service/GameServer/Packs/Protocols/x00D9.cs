#pragma warning disable CS8618

using TouchSocket.Core;
using GameServer.Service;

namespace GameServer.Packs.Protocol
{
    /// <summary>
    /// <para>BookMarfaPrivilegesPacket</para>
    /// <para>BookMarfaPrivilegesPacket</para>
    /// </summary>
    internal class x00D9 : Package
    {
        #region public

		public Byte 特权类型;
        #endregion

        #region marshal


        #endregion

        #region attribute

        public ushort Type => 0x00D9;
        public ushort Size => 3;     
        public ushort rSize => 0;
        #endregion
        
        public x00D9() 
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
			特权类型 = byteBlock.ReadByte();
			return byteBlock;
        }

        public void Process(GameSession gameSession)
        {
            throw new NotImplementedException();
        }
    }
}

