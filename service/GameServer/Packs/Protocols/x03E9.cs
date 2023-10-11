#pragma warning disable CS8618

using TouchSocket.Core;
using GameServer.Service;

namespace GameServer.Packs.Protocol
{
    /// <summary>
    /// <para>客户登录</para>
    /// <para>UserLoginPacket</para>
    /// </summary>
    internal class x03E9 : Package
    {
        #region public field

		public String Ticket;
		public String MacAddress;
        #endregion

        #region public attribute

        public ushort Type => 0x03E9;
        public ushort Size => 162;        
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

