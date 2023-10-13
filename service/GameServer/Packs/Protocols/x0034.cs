#pragma warning disable CS8618

using TouchSocket.Core;
using GameServer.Service;

namespace GameServer.Packs.Protocols
{
    /// <summary>
    /// <para>CharacterRepurchageItemsPacket</para>
    /// <para>CharacterRepurchageItemsPacket</para>
    /// </summary>
    internal class x0034 : Package
    {
        #region public

        public byte 物品位置;
        #endregion

        #region marshal


        #endregion

        #region attribute

        public ushort Type => 0x0034;
        public ushort Size => 3;
        public ushort rSize => 0;
        #endregion

        public x0034()
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
            物品位置 = byteBlock.ReadByte();
            return byteBlock;
        }

        public void Process(GameSession gameSession)
        {
            throw new NotImplementedException();
        }
    }
}

