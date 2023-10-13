#pragma warning disable CS8618

using TouchSocket.Core;
using GameServer.Service;

namespace GameServer.Packs.Protocols
{
    /// <summary>
    /// <para>PutItemsInBoothPacket</para>
    /// <para>PutItemsInBoothPacket</para>
    /// </summary>
    internal class x006B : Package
    {
        #region public

        public byte 放入位置;
        public byte 物品容器;
        public byte 物品位置;
        public ushort 物品数量;
        public int 物品价格;
        #endregion

        #region marshal


        #endregion

        #region attribute

        public ushort Type => 0x006B;
        public ushort Size => 11;
        public ushort rSize => 0;
        #endregion

        public x006B()
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
            放入位置 = byteBlock.ReadByte();
            物品容器 = byteBlock.ReadByte();
            物品位置 = byteBlock.ReadByte();
            物品数量 = byteBlock.ReadUInt16();
            物品价格 = byteBlock.ReadInt32();
            return byteBlock;
        }

        public void Process(GameSession gameSession)
        {
            throw new NotImplementedException();
        }
    }
}

