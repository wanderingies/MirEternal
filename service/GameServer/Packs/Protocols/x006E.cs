#pragma warning disable CS8618

using TouchSocket.Core;
using GameServer.Service;

namespace GameServer.Packs.Protocols
{
    /// <summary>
    /// <para>更改摊位外观</para>
    /// <para>更改摊位外观</para>
    /// </summary>
    internal class x006E : Package
    {
        #region public

        public byte 外观编号;
        #endregion

        #region marshal


        #endregion

        #region attribute

        public ushort Type => 0x006E;
        public ushort Size => 3;
        public ushort rSize => 0;
        #endregion

        public x006E()
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
            外观编号 = byteBlock.ReadByte();
            return byteBlock;
        }

        public void Process(GameSession gameSession)
        {
            throw new NotImplementedException();
        }
    }
}

