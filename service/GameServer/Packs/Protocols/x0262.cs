#pragma warning disable CS8618

using TouchSocket.Core;
using GameServer.Service;

namespace GameServer.Packs.Protocol
{
    /// <summary>
    /// <para>SendMessageCodeVerificationPacket</para>
    /// <para>SendMessageCodeVerificationPacket</para>
    /// </summary>
    internal class x0262 : Package
    {
        #region public

		public String Code;
        #endregion

        #region marshal


        #endregion

        #region attribute

        public ushort Type => 0x0262;
        public ushort Size => 9;     
        public ushort rSize => 0;
        #endregion
        
        public x0262() 
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
			throw new NotImplementedException();
        }

        public void Process(GameSession gameSession)
        {
            throw new NotImplementedException();
        }
    }
}

