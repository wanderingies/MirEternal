#pragma warning disable CS8618

using TouchSocket.Core;
using GameServer.Service;

namespace GameServer.Packs.Protocols
{
    /// <summary>
    /// <para>好友聊天</para>
    /// <para>SendFriendChatPacket</para>
    /// </summary>
    internal class x020E : Package
    {
        #region public

        #endregion

        #region marshal


        #endregion

        #region attribute

        public ushort Type => 0x020E;
        public ushort Size => 0;
        public ushort rSize => 0;
        #endregion

        public x020E()
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

