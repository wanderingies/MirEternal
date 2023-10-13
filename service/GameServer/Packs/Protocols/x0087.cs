#pragma warning disable CS8618

using TouchSocket.Core;
using GameServer.Service;

namespace GameServer.Packs.Protocols
{
    /// <summary>
    /// <para>CreateNewFriendGroupPacket(已屏蔽)</para>
    /// <para>CreateNewFriendGroupPacket</para>
    /// </summary>
    internal class x0087 : Package
    {
        #region public

        #endregion

        #region marshal


        #endregion

        #region attribute

        public ushort Type => 0x0087;
        public ushort Size => 28;
        public ushort rSize => 0;
        #endregion

        public x0087()
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

