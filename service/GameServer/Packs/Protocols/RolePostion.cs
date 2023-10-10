#pragma warning disable CS8618

using TouchSocket.Core;
using GameServer.Service;

namespace GameServer.Packs.Protocol
{
    /// <summary>
    /// 上传角色位置
    /// </summary>
    internal class RolePostion : Package
    {
        #region public field

        public UInt16 高度;

        public byte[] State;
        #endregion

        #region public attribute

        public ushort Type => 0x000E;
        public ushort Size => 10;
        #endregion

        #region private field


        #endregion

        public RolePostion()
        {
            State = new byte[] { 0 };
        }

        public ByteBlock Marshal(ByteBlock byteBlock)
        {
            byteBlock.Write(State);
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

