#pragma warning disable CS8618

using TouchSocket.Core;
using GameServer.Service;

namespace GameServer.Packs.Protocols
{
    /// <summary>
    /// <para>取回摊位物品</para>
    /// <para>取回摊位物品</para>
    /// </summary>
    internal class x006C : Package
    {
        #region public

        public byte 取回位置;
        #endregion

        #region marshal


        #endregion

        #region attribute

        public ushort Type => 0x006C;
        public ushort Size => 3;
        public ushort rSize => 0;
        #endregion

        public x006C()
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
            取回位置 = byteBlock.ReadByte();
            return byteBlock;
        }

        public void Process(GameSession gameSession)
        {
            throw new NotImplementedException();
        }
    }
}

