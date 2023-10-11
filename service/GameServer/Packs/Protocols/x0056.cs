#pragma warning disable CS8618

using TouchSocket.Core;
using GameServer.Service;

namespace GameServer.Packs.Protocol
{
    /// <summary>
    /// <para>CharacterBreakdownItemsPacket</para>
    /// <para>CharacterBreakdownItemsPacket</para>
    /// </summary>
    internal class x0056 : Package
    {
        #region public field

		public Byte 背包类型;
		public Byte 物品位置;
		public Byte 分解数量;
        #endregion

        #region public attribute

        public ushort Type => 0x0056;
        public ushort Size => 5;        
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
			分解数量 = byteBlock.ReadByte();
            return byteBlock;
        }

        public void Process(GameSession session)
        {
            
        }
    }
}

