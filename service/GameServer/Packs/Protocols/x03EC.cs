#pragma warning disable CS8618

using TouchSocket.Core;
using GameServer.Service;

namespace GameServer.Packs.Protocols
{
    /// <summary>
    /// <para>用户删除角色</para>
    /// <para>UserDelectRolePacket</para>
    /// </summary>
    internal class x03EC : Package
    {
        #region public

        public int roleid;
        #endregion

        #region marshal


        #endregion

        #region attribute

        public ushort Type => 0x03EC;
        public ushort Size => 6;
        public ushort rSize => 0;
        #endregion

        public x03EC()
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
            roleid = byteBlock.ReadInt32();
            return byteBlock;
        }

        public void Process(GameSession gameSession)
        {
            throw new NotImplementedException();
        }
    }
}

