#pragma warning disable CS8618

using TouchSocket.Core;
using GameServer.Service;

namespace GameServer.Packs.Protocols
{
    /// <summary>
    /// <para>GuildWarehouseTransferOutPacket</para>
    /// <para>GuildWarehouseTransferOutPacket</para>
    /// </summary>
    internal class x00A6 : Package
    {
        #region public

        public byte 仓库页面;
        public byte 仓库位置;
        public byte 目标容器;
        public byte 目标位置;
        #endregion

        #region marshal


        #endregion

        #region attribute

        public ushort Type => 0x00A6;
        public ushort Size => 8;
        public ushort rSize => 0;
        #endregion

        public x00A6()
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
            仓库页面 = byteBlock.ReadByte();
            仓库位置 = byteBlock.ReadByte();
            目标容器 = byteBlock.ReadByte();
            目标位置 = byteBlock.ReadByte();
            return byteBlock;
        }

        public void Process(GameSession gameSession)
        {
            throw new NotImplementedException();
        }
    }
}

