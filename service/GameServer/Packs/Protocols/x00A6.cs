#pragma warning disable CS8618

using TouchSocket.Core;
using GameServer.Service;

namespace GameServer.Packs.Protocol
{
    /// <summary>
    /// <para>GuildWarehouseTransferOutPacket</para>
    /// <para>GuildWarehouseTransferOutPacket</para>
    /// </summary>
    internal class x00A6 : Package
    {
        #region public field

		public Byte 仓库页面;
		public Byte 仓库位置;
		public Byte 目标容器;
		public Byte 目标位置;
        #endregion

        #region public attribute

        public ushort Type => 0x00A6;
        public ushort Size => 8;        
        #endregion
        
        #region private field


        #endregion

        public ByteBlock Marshal(ByteBlock byteBlock)
        {
            return byteBlock;
        }

        public ByteBlock UnMarshal(ByteBlock byteBlock)
        {
			仓库页面 = byteBlock.ReadByte();
			仓库位置 = byteBlock.ReadByte();
			目标容器 = byteBlock.ReadByte();
			目标位置 = byteBlock.ReadByte();
            return byteBlock;
        }

        public void Process(GameSession session)
        {
            
        }
    }
}

