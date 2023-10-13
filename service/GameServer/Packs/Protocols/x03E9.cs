#pragma warning disable CS8618

using TouchSocket.Core;
using GameServer.Service;

namespace GameServer.Packs.Protocols
{
    /// <summary>
    /// <para>客户登录</para>
    /// <para>UserLoginPacket</para>
    /// </summary>
    internal class x03E9 : Package
    {
        #region public

        public string Ticket;
        public string MacAddress;
        #endregion

        #region marshal


        #endregion

        #region attribute

        public ushort Type => 0x03E9;
        public ushort Size => 162;
        public ushort rSize => 0;
        #endregion

        public x03E9()
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

