#pragma warning disable CS8618

using TouchSocket.Core;
using WorldServer.Service;

namespace WorldServer.Packs.Protocol
{
    /// <summary>
    /// <para>SyncBackpackSizePacket 仓库 背包 资源包...</para>
    /// <para>SyncBackpackSizePacket</para>
    /// </summary>
    internal class x000F : Package
    {
        #region public field

		public Byte 穿戴大小;
		public Byte BackpackSize;
		public Byte WarehouseSize;
		public Byte u1;
		public Byte u2;
		public Byte u3;
		public Byte u4;
		public Byte ExtraBackpackSize;
		public Byte u5;
        #endregion

        #region public attribute

        public ushort Type => 0x000F;
        public ushort Size => 11;        
        #endregion
        
        #region private field


        #endregion

        public ByteBlock Marshal(ByteBlock byteBlock)
        {
			byteBlock.Write(穿戴大小);
			byteBlock.Write(BackpackSize);
			byteBlock.Write(WarehouseSize);
			byteBlock.Write(u1);
			byteBlock.Write(u2);
			byteBlock.Write(u3);
			byteBlock.Write(u4);
			byteBlock.Write(ExtraBackpackSize);
			byteBlock.Write(u5);
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

