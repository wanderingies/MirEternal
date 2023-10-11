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
        #region public field

		public String Code;
        #endregion

        #region public attribute

        public ushort Type => 0x0262;
        public ushort Size => 9;        
        #endregion
        
        #region private field


        #endregion

        public ByteBlock Marshal(ByteBlock byteBlock)
        {
            return byteBlock;
        }

        public ByteBlock UnMarshal(ByteBlock byteBlock)
        {
            return byteBlock;
        }

        public void Process(GameSession session)
        {
            
        }
    }
}

