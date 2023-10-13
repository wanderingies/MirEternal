#pragma warning disable CS8618

using TouchSocket.Core;
using GameServer.Service;

namespace GameServer.Packs.Protocols
{
    /// <summary>
    /// <para>物品转移/交换/合并/更换装备</para>
    /// <para>CharacterTransferItemPacket</para>
    /// </summary>
    internal class x002C : Package
    {
        #region public

        public byte 当前背包;
        public byte 原有位置;
        public byte 目标背包;
        public byte 目标位置;
        #endregion

        #region marshal


        #endregion

        #region attribute

        public ushort Type => 0x002C;
        public ushort Size => 6;
        public ushort rSize => 0;
        #endregion

        public x002C()
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
            当前背包 = byteBlock.ReadByte();
            原有位置 = byteBlock.ReadByte();
            目标背包 = byteBlock.ReadByte();
            目标位置 = byteBlock.ReadByte();
            return byteBlock;
        }

        public void Process(GameSession gameSession)
        {
            throw new NotImplementedException();
        }
    }
}

