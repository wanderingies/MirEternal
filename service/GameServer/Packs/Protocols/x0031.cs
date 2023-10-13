#pragma warning disable CS8618

using TouchSocket.Core;
using GameServer.Service;

namespace GameServer.Packs.Protocols
{
    /// <summary>
    /// <para>CharacterPurchageItemsPacket</para>
    /// <para>CharacterPurchageItemsPacket</para>
    /// </summary>
    internal class x0031 : Package
    {
        #region public

        public int StoreId;
        public int 物品位置;
        public ushort 购入数量;
        #endregion

        #region marshal


        #endregion

        #region attribute

        public ushort Type => 0x0031;
        public ushort Size => 12;
        public ushort rSize => 0;
        #endregion

        public x0031()
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
            StoreId = byteBlock.ReadInt32();
            物品位置 = byteBlock.ReadInt32();
            购入数量 = byteBlock.ReadUInt16();
            return byteBlock;
        }

        public void Process(GameSession gameSession)
        {
            throw new NotImplementedException();
        }
    }
}

