#pragma warning disable CS8618

using TouchSocket.Core;
using GameServer.Service;

namespace GameServer.Packs.Protocol
{
    /// <summary>
    /// <para>CharacterSplitItemsPacket</para>
    /// <para>CharacterSplitItemsPacket</para>
    /// </summary>
    internal class x002E : Package
    {
        #region public

		public Byte 当前背包;
		public Byte 物品位置;
		public Byte 目标背包;
		public Byte 目标位置;
		public UInt16 拆分数量;
        #endregion

        #region marshal


        #endregion

        #region attribute

        public ushort Type => 0x002E;
        public ushort Size => 8;     
        public ushort rSize => 0;
        #endregion
        
        public x002E() 
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
			物品位置 = byteBlock.ReadByte();
			目标背包 = byteBlock.ReadByte();
			目标位置 = byteBlock.ReadByte();
			拆分数量 = byteBlock.ReadUInt16();
			return byteBlock;
        }

        public void Process(GameSession gameSession)
        {
            throw new NotImplementedException();
        }
    }
}

