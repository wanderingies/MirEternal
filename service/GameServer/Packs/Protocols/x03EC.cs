#pragma warning disable CS8618

using TouchSocket.Core;
using GameServer.Service;

namespace GameServer.Packs.Protocol
{
    /// <summary>
    /// <para>用户删除角色</para>
    /// <para>UserDelectRolePacket</para>
    /// </summary>
    internal class x03EC : Package
    {
        #region public field

		public Int32 roleid;
        #endregion

        #region public attribute

        public ushort Type => 0x03EC;
        public ushort Size => 6;        
        #endregion
        
        #region private field


        #endregion

        public ByteBlock Marshal(ByteBlock byteBlock)
        {
            return byteBlock;
        }

        public ByteBlock UnMarshal(ByteBlock byteBlock)
        {
			roleid = byteBlock.ReadInt32();
            return byteBlock;
        }

        public void Process(GameSession session)
        {
            
        }
    }
}

