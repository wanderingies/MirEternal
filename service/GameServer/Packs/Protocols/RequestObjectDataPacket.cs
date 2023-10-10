#pragma warning disable CS8618

using TouchSocket.Core;
using GameServer.Service;

namespace GameServer.Packs.Protocol
{
    /// <summary>
    /// RequestObjectDataPacket, 对应服务端0041封包
    /// </summary>
    internal class RequestObjectDataPacket : Package
    {
        #region public field

        public Int32 对象编号;
        public Int32 状态编号;

        public byte[] Shortcutbar;
        #endregion

        #region public attribute

        public ushort Type => 0x0013;
        public ushort Size => 10;
        #endregion

        #region private field


        #endregion

        public RequestObjectDataPacket()
        {
            Shortcutbar = new byte[] { 0 };
        }

        public ByteBlock Marshal(ByteBlock byteBlock)
        {
            byteBlock.Write(Shortcutbar);
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

