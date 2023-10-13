#pragma warning disable CS8618

using TouchSocket.Core;
using GameServer.Service;

namespace GameServer.Packs.Protocols
{
    /// <summary>
    /// <para>CharacterUseItemsPacket</para>
    /// <para>CharacterUseItemsPacket</para>
    /// </summary>
    internal class x002D : Package
    {
        #region public

        public byte 背包类型;
        public byte 物品位置;
        #endregion

        #region marshal

        public int SyncTime;
        #endregion

        #region attribute

        public ushort Type => 0x002D;
        public ushort Size => 4;
        public ushort rSize => 6;
        #endregion

        public x002D()
        {
        }

        #region private


        #endregion

        public ByteBlock Marshal(ByteBlock byteBlock)
        {
            byteBlock.Write(SyncTime);
            return byteBlock;
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

