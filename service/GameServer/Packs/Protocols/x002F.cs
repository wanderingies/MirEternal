#pragma warning disable CS8618

using TouchSocket.Core;
using GameServer.Service;

namespace GameServer.Packs.Protocol
{
    /// <summary>
    /// <para>CharacterDropsItemsPacket</para>
    /// <para>CharacterDropsItemsPacket</para>
    /// </summary>
    internal class x002F : Package
    {
        #region public field

		public Byte 背包类型;
		public Byte 物品位置;
		public UInt16 丢弃数量;
        #endregion

        #region public attribute

        public ushort Type => 0x002F;
        public ushort Size => 6;        
        #endregion
        
        #region private field


        #endregion

        public ByteBlock Marshal(ByteBlock byteBlock)
        {
            return byteBlock;
        }

        public ByteBlock UnMarshal(ByteBlock byteBlock)
        {
			背包类型 = byteBlock.ReadByte();
			物品位置 = byteBlock.ReadByte();
			丢弃数量 = byteBlock.ReadUInt16();
            return byteBlock;
        }

        public void Process(GameSession session)
        {
            
        }
    }
}

