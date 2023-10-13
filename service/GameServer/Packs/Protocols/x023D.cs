#pragma warning disable CS8618

using TouchSocket.Core;
using GameServer.Service;

namespace GameServer.Packs.Protocol
{
    /// <summary>
    /// <para>GuildWarehouseMovePacket</para>
    /// <para>GuildWarehouseMovePacket</para>
    /// </summary>
    internal class x023D : Package
    {
        #region public

		public Byte 原有页面;
		public Byte 原有位置;
		public Byte 目标页面;
		public Byte 目标位置;
        #endregion

        #region marshal


        #endregion

        #region attribute

        public ushort Type => 0x023D;
        public ushort Size => 8;     
        public ushort rSize => 0;
        #endregion
        
        public x023D() 
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
			原有页面 = byteBlock.ReadByte();
			原有位置 = byteBlock.ReadByte();
			目标页面 = byteBlock.ReadByte();
			目标位置 = byteBlock.ReadByte();
			return byteBlock;
        }

        public void Process(GameSession gameSession)
        {
            throw new NotImplementedException();
        }
    }
}

