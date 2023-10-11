#pragma warning disable CS8618

using TouchSocket.Core;
using GameServer.Service;

namespace GameServer.Packs.Protocol
{
    /// <summary>
    /// <para>玩家喝修复油</para>
    /// <para>玩家喝修复油</para>
    /// </summary>
    internal class x00F1 : Package
    {
        #region public field

		public Byte 背包类型;
		public Byte 物品位置;
        #endregion

        #region public attribute

        public ushort Type => 0x00F1;
        public ushort Size => 4;        
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
            return byteBlock;
        }

        public void Process(GameSession session)
        {
            
        }
    }
}

