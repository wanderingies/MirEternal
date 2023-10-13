#pragma warning disable CS8618

using TouchSocket.Core;
using GameServer.Service;

namespace GameServer.Packs.Protocols
{
    /// <summary>
    /// <para>AddFriendsToFollowPacket</para>
    /// <para>AddFriendsToFollowPacket</para>
    /// </summary>
    internal class x020A : Package
    {
        #region public

        public int 对象编号;
        public string 对象名字;
        #endregion

        #region marshal


        #endregion

        #region attribute

        public ushort Type => 0x020A;
        public ushort Size => 38;
        public ushort rSize => 0;
        #endregion

        public x020A()
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
            对象编号 = byteBlock.ReadInt32();
            return byteBlock;
        }

        public void Process(GameSession gameSession)
        {
            throw new NotImplementedException();
        }
    }
}

