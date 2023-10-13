#pragma warning disable CS8618

using TouchSocket.Core;
using GameServer.Service;

namespace GameServer.Packs.Protocols
{
    /// <summary>
    /// <para>GuildWarehouseRefreshPacket</para>
    /// <para>GuildWarehouseRefreshPacket</para>
    /// </summary>
    internal class x00A4 : Package
    {
        #region public

        public byte 仓库页面;
        #endregion

        #region marshal


        #endregion

        #region attribute

        public ushort Type => 0x00A4;
        public ushort Size => 8;
        public ushort rSize => 0;
        #endregion

        public x00A4()
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
            return byteBlock;
        }

        public void Process(GameSession gameSession)
        {
            throw new NotImplementedException();
        }
    }
}

