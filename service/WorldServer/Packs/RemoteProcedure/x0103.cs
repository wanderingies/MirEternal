#pragma warning disable CS8618

using TouchSocket.Core;
using WorldServer.Service;

namespace WorldServer.Packs.Protocol
{
    /// <summary>
    /// <para>DecompositionItemResponsePacket</para>
    /// <para>DecompositionItemResponsePacket</para>
    /// </summary>
    internal class x0103 : Package
    {
        #region public field

		public Byte 分解数量;
		public Int32 分解物品;
		public Int32 分解物一;
		public Int32 分解物二;
		public Int32 分解物三;
		public Int32 物品数一;
		public Int32 物品数二;
		public Int32 物品数三;
        #endregion

        #region public attribute

        public ushort Type => 0x0103;
        public ushort Size => 31;        
        #endregion
        
        #region private field


        #endregion

        public ByteBlock Marshal(ByteBlock byteBlock)
        {
			byteBlock.Write(分解数量);
			byteBlock.Write(分解物品);
			byteBlock.Write(分解物一);
			byteBlock.Write(分解物二);
			byteBlock.Write(分解物三);
			byteBlock.Write(物品数一);
			byteBlock.Write(物品数二);
			byteBlock.Write(物品数三);
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

