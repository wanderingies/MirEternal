#pragma warning disable CS8618

using TouchSocket.Core;
using GameServer.Service;

namespace GameServer.Packs.Protocols
{
    /// <summary>
    /// <para>玩家请求复活</para>
    /// <para>客户请求复活</para>
    /// </summary>
    internal class x0018 : Package
    {
        #region public

        public byte 复活方式;
        #endregion

        #region marshal


        #endregion

        #region attribute

        public ushort Type => 0x0018;
        public ushort Size => 3;
        public ushort rSize => 0;
        #endregion

        public x0018()
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
            复活方式 = byteBlock.ReadByte();
            return byteBlock;
        }

        public void Process(GameSession gameSession)
        {
            throw new NotImplementedException();
        }
    }
}

