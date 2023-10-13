#pragma warning disable CS8618

using TouchSocket.Core;
using GameServer.Service;

namespace GameServer.Packs.Protocol
{
    /// <summary>
    /// <para>InviteToJoinGuildPacket</para>
    /// <para>InviteToJoinGuildPacket</para>
    /// </summary>
    internal class x022F : Package
    {
        #region public

		public String 对象名字;
        #endregion

        #region marshal


        #endregion

        #region attribute

        public ushort Type => 0x022F;
        public ushort Size => 34;     
        public ushort rSize => 0;
        #endregion
        
        public x022F() 
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

