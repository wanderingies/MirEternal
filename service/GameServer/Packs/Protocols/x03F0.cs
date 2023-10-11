#pragma warning disable CS8618

using TouchSocket.Core;
using GameServer.Service;

namespace GameServer.Packs.Protocol
{
    /// <summary>
    /// <para>更改角色名称</para>
    /// <para>UserChangeRolePacket</para>
    /// </summary>
    internal class x03F0 : Package
    {
        #region public field

        #endregion

        #region public attribute

        public ushort Type => 0x03F0;
        public ushort Size => 38;        
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

