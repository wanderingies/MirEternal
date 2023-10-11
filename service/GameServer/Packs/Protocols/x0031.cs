#pragma warning disable CS8618

using TouchSocket.Core;
using GameServer.Service;

namespace GameServer.Packs.Protocol
{
    /// <summary>
    /// <para>CharacterPurchageItemsPacket</para>
    /// <para>CharacterPurchageItemsPacket</para>
    /// </summary>
    internal class x0031 : Package
    {
        #region public field

		public Int32 StoreId;
		public Int32 物品位置;
		public UInt16 购入数量;
        #endregion

        #region public attribute

        public ushort Type => 0x0031;
        public ushort Size => 12;        
        #endregion
        
        #region private field


        #endregion

        public ByteBlock Marshal(ByteBlock byteBlock)
        {
            return byteBlock;
        }

        public ByteBlock UnMarshal(ByteBlock byteBlock)
        {
			StoreId = byteBlock.ReadInt32();
			物品位置 = byteBlock.ReadInt32();
			购入数量 = byteBlock.ReadUInt16();
            return byteBlock;
        }

        public void Process(GameSession session)
        {
            
        }
    }
}

