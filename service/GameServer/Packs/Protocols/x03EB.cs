#pragma warning disable CS8618

using TouchSocket.Core;
using GameServer.Service;

namespace GameServer.Packs.Protocol
{
    /// <summary>
    /// <para>冻结角色</para>
    /// <para>UserFreezeRolePacket</para>
    /// </summary>
    internal class x03EB : Package
    {
        #region public field

		public Int32 角色编号;
        #endregion

        #region public attribute

        public ushort Type => 0x03EB;
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
			角色编号 = byteBlock.ReadInt32();
            return byteBlock;
        }

        public void Process(GameSession session)
        {
            
        }
    }
}

