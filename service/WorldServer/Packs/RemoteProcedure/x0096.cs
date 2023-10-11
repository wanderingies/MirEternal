#pragma warning disable CS8618

using TouchSocket.Core;
using WorldServer.Service;

namespace WorldServer.Packs.Protocol
{
    /// <summary>
    /// <para>掉落物品</para>
    /// <para>ObjectDropItemsPacket</para>
    /// </summary>
    internal class x0096 : Package
    {
        #region public field

		public UInt16 Unknown1;
		public Int32 DropperObjectId;
		public Int32 ItemObjectId;
		public UInt16 掉落高度;
		public Int32 ItemId;
		public Int32 物品数量;
		public Int32 Unknown2;
		public Int32 OwnerPlayerId;
        #endregion

        #region public attribute

        public ushort Type => 0x0096;
        public ushort Size => 34;        
        #endregion
        
        #region private field


        #endregion

        public ByteBlock Marshal(ByteBlock byteBlock)
        {
			byteBlock.Write(Unknown1);
			byteBlock.Write(DropperObjectId);
			byteBlock.Write(ItemObjectId);
			byteBlock.Write(掉落高度);
			byteBlock.Write(ItemId);
			byteBlock.Write(物品数量);
			byteBlock.Write(Unknown2);
			byteBlock.Write(OwnerPlayerId);
            return byteBlock;
        }

        public ByteBlock UnMarshal(ByteBlock byteBlock)
        {
            return byteBlock;
        }

        public void Process(WorldSession session)
        {
            
        }
    }
}

