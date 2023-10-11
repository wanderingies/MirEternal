#pragma warning disable CS8618

using TouchSocket.Core;
using WorldServer.Service;

namespace WorldServer.Packs.Protocol
{
    /// <summary>
    /// <para>物品转移或交换</para>
    /// <para>玩家转移物品</para>
    /// </summary>
    internal class x0081 : Package
    {
        #region public field

		public Byte 原有容器;
		public Byte 原有位置;
		public Byte 目标容器;
		public Byte 目标位置;
        #endregion

        #region public attribute

        public ushort Type => 0x0081;
        public ushort Size => 6;        
        #endregion
        
        #region private field


        #endregion

        public ByteBlock Marshal(ByteBlock byteBlock)
        {
			byteBlock.Write(原有容器);
			byteBlock.Write(原有位置);
			byteBlock.Write(目标容器);
			byteBlock.Write(目标位置);
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

