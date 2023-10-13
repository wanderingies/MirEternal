#pragma warning disable CS8618

using TouchSocket.Core;
using GameServer.Service;

namespace GameServer.Packs.Protocol
{
    /// <summary>
    /// <para>GuildWarehouseTransferPacket</para>
    /// <para>GuildWarehouseTransferPacket</para>
    /// </summary>
    internal class x00A5 : Package
    {
        #region public

		public Byte 原来容器;
		public Byte 原来位置;
		public Byte 仓库页面;
		public Byte 仓库位置;
        #endregion

        #region marshal


        #endregion

        #region attribute

        public ushort Type => 0x00A5;
        public ushort Size => 8;     
        public ushort rSize => 0;
        #endregion
        
        public x00A5() 
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
			原来容器 = byteBlock.ReadByte();
			原来位置 = byteBlock.ReadByte();
			仓库页面 = byteBlock.ReadByte();
			仓库位置 = byteBlock.ReadByte();
			return byteBlock;
        }

        public void Process(GameSession gameSession)
        {
            throw new NotImplementedException();
        }
    }
}

