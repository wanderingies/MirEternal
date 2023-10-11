#pragma warning disable CS8618

using TouchSocket.Core;
using GameServer.Service;

namespace GameServer.Packs.Protocol
{
    /// <summary>
    /// <para>GuildWarehouseRefreshPacket</para>
    /// <para>GuildWarehouseRefreshPacket</para>
    /// </summary>
    internal class x00A4 : Package
    {
        #region public field

		public Byte 仓库页面;
        #endregion

        #region public attribute

        public ushort Type => 0x00A4;
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
            return byteBlock;
        }

        public void Process(GameSession session)
        {
            
        }
    }
}

