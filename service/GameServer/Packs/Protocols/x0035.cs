#pragma warning disable CS8618

using TouchSocket.Core;
using GameServer.Service;

namespace GameServer.Packs.Protocols
{
    /// <summary>
    /// <para>商店修理单件</para>
    /// <para>商店修理单件</para>
    /// </summary>
    internal class x0035 : Package
    {
        #region public

        public byte 背包类型;
        public byte 物品位置;
        #endregion

        #region marshal


        #endregion

        #region attribute

        public ushort Type => 0x0035;
        public ushort Size => 4;
        public ushort rSize => 0;
        #endregion

        public x0035()
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
            背包类型 = byteBlock.ReadByte();
            物品位置 = byteBlock.ReadByte();
            return byteBlock;
        }

        public void Process(GameSession gameSession)
        {
            throw new NotImplementedException();
        }
    }
}

