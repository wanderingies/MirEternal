#pragma warning disable CS8618

using TouchSocket.Core;
using GameServer.Service;

namespace GameServer.Packs.Protocol
{
    /// <summary>
    /// <para>玩家放入物品</para>
    /// <para>玩家放入物品</para>
    /// </summary>
    internal class x0096 : Package
    {
        #region public field

		public Byte 放入位置;
		public Byte 放入物品;
		public Byte 物品容器;
		public Byte 物品位置;
        #endregion

        #region public attribute

        public ushort Type => 0x0096;
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
			放入位置 = byteBlock.ReadByte();
			放入物品 = byteBlock.ReadByte();
			物品容器 = byteBlock.ReadByte();
			物品位置 = byteBlock.ReadByte();
            return byteBlock;
        }

        public void Process(GameSession session)
        {
            
        }
    }
}

