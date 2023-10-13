#pragma warning disable CS8618

using TouchSocket.Core;
using GameServer.Service;

namespace GameServer.Packs.Protocol
{
    /// <summary>
    /// <para>购买摊位物品</para>
    /// <para>购买摊位物品</para>
    /// </summary>
    internal class x0070 : Package
    {
        #region public

		public Int32 对象编号;
		public Byte 物品位置;
		public UInt16 购买数量;
        #endregion

        #region marshal


        #endregion

        #region attribute

        public ushort Type => 0x0070;
        public ushort Size => 17;     
        public ushort rSize => 0;
        #endregion
        
        public x0070() 
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
			对象编号 = byteBlock.ReadInt32();
			物品位置 = byteBlock.ReadByte();
			购买数量 = byteBlock.ReadUInt16();
			return byteBlock;
        }

        public void Process(GameSession gameSession)
        {
            throw new NotImplementedException();
        }
    }
}

