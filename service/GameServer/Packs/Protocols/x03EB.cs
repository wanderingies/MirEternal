#pragma warning disable CS8618

using TouchSocket.Core;
using GameServer.Service;

namespace GameServer.Packs.Protocols
{
    /// <summary>
    /// <para>冻结角色</para>
    /// <para>UserFreezeRolePacket</para>
    /// </summary>
    internal class x03EB : Package
    {
        #region public

        public int 角色编号;
        #endregion

        #region marshal


        #endregion

        #region attribute

        public ushort Type => 0x03EB;
        public ushort Size => 6;
        public ushort rSize => 0;
        #endregion

        public x03EB()
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
            角色编号 = byteBlock.ReadInt32();
            return byteBlock;
        }

        public void Process(GameSession gameSession)
        {
            throw new NotImplementedException();
        }
    }
}

