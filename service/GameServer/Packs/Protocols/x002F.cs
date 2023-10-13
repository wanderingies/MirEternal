#pragma warning disable CS8618

using TouchSocket.Core;
using GameServer.Service;

namespace GameServer.Packs.Protocols
{
    /// <summary>
    /// <para>CharacterDropsItemsPacket</para>
    /// <para>CharacterDropsItemsPacket</para>
    /// </summary>
    internal class x002F : Package
    {
        #region public

        public byte 背包类型;
        public byte 物品位置;
        public ushort 丢弃数量;
        #endregion

        #region marshal


        #endregion

        #region attribute

        public ushort Type => 0x002F;
        public ushort Size => 6;
        public ushort rSize => 0;
        #endregion

        public x002F()
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
            丢弃数量 = byteBlock.ReadUInt16();
            return byteBlock;
        }

        public void Process(GameSession gameSession)
        {
            throw new NotImplementedException();
        }
    }
}

