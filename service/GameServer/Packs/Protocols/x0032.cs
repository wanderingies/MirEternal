#pragma warning disable CS8618

using TouchSocket.Core;
using GameServer.Service;

namespace GameServer.Packs.Protocol
{
    /// <summary>
    /// <para>CharacterSellItemsPacket</para>
    /// <para>CharacterSellItemsPacket</para>
    /// </summary>
    internal class x0032 : Package
    {
        #region public

		public Byte 背包类型;
		public Byte 物品位置;
		public UInt16 卖出数量;
        #endregion

        #region marshal


        #endregion

        #region attribute

        public ushort Type => 0x0032;
        public ushort Size => 6;     
        public ushort rSize => 0;
        #endregion
        
        public x0032() 
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
			背包类型 = byteBlock.ReadByte();
			物品位置 = byteBlock.ReadByte();
			卖出数量 = byteBlock.ReadUInt16();
			return byteBlock;
        }

        public void Process(GameSession gameSession)
        {
            throw new NotImplementedException();
        }
    }
}

