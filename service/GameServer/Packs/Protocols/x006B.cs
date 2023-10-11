#pragma warning disable CS8618

using TouchSocket.Core;
using GameServer.Service;

namespace GameServer.Packs.Protocol
{
    /// <summary>
    /// <para>PutItemsInBoothPacket</para>
    /// <para>PutItemsInBoothPacket</para>
    /// </summary>
    internal class x006B : Package
    {
        #region public field

		public Byte 放入位置;
		public Byte 物品容器;
		public Byte 物品位置;
		public UInt16 物品数量;
		public Int32 物品价格;
        #endregion

        #region public attribute

        public ushort Type => 0x006B;
        public ushort Size => 11;        
        #endregion
        
        #region private field


        #endregion

        public ByteBlock Marshal(ByteBlock byteBlock)
        {
            return byteBlock;
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

        public void Process(GameSession session)
        {
            
        }
    }
}

