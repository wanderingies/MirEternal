#pragma warning disable CS8618

using TouchSocket.Core;
using GameServer.Service;

namespace GameServer.Packs.Protocols
{
    /// <summary>
    /// <para>CharacterBreakdownItemsPacket</para>
    /// <para>CharacterBreakdownItemsPacket</para>
    /// </summary>
    internal class x0056 : Package
    {
        #region public

        public byte 背包类型;
        public byte 物品位置;
        public byte 分解数量;
        #endregion

        #region marshal


        #endregion

        #region attribute

        public ushort Type => 0x0056;
        public ushort Size => 5;
        public ushort rSize => 0;
        #endregion

        public x0056()
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
            分解数量 = byteBlock.ReadByte();
            return byteBlock;
        }

        public void Process(GameSession gameSession)
        {
            throw new NotImplementedException();
        }
    }
}

