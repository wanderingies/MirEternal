#pragma warning disable CS8618

using TouchSocket.Core;
using WorldServer.Service;

namespace WorldServer.Packs.Protocol
{
    /// <summary>
    /// <para>删除物品</para>
    /// <para>删除玩家物品</para>
    /// </summary>
    internal class x0082 : Package
    {
        #region public field

		public Byte 背包类型;
		public Byte 物品位置;
        #endregion

        #region public attribute

        public ushort Type => 0x0082;
        public ushort Size => 4;        
        #endregion
        
        #region private field


        #endregion

        public ByteBlock Marshal(ByteBlock byteBlock)
        {
			byteBlock.Write(背包类型);
			byteBlock.Write(物品位置);
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

