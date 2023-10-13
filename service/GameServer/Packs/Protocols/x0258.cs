#pragma warning disable CS8618

using TouchSocket.Core;
using GameServer.Service;

namespace GameServer.Packs.Protocols
{
    /// <summary>
    /// <para>购买珍宝商品</para>
    /// <para>购买珍宝商品</para>
    /// </summary>
    internal class x0258 : Package
    {
        #region public

        public int Id;
        public int 购买数量;
        #endregion

        #region marshal


        #endregion

        #region attribute

        public ushort Type => 0x0258;
        public ushort Size => 42;
        public ushort rSize => 0;
        #endregion

        public x0258()
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
            Id = byteBlock.ReadInt32();
            购买数量 = byteBlock.ReadInt32();
            return byteBlock;
        }

        public void Process(GameSession gameSession)
        {
            throw new NotImplementedException();
        }
    }
}

