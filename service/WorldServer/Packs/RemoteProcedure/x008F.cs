#pragma warning disable CS8618

using TouchSocket.Core;
using WorldServer.Service;

namespace WorldServer.Packs.Protocol
{
    /// <summary>
    /// <para>EquipPermanentChangePacket</para>
    /// <para>EquipPermanentChangePacket</para>
    /// </summary>
    internal class x008F : Package
    {
        #region public field

		public Byte 装备容器;
		public Byte 装备位置;
		public Int32 当前持久;
        #endregion

        #region public attribute

        public ushort Type => 0x008F;
        public ushort Size => 8;        
        #endregion
        
        #region private field


        #endregion

        public ByteBlock Marshal(ByteBlock byteBlock)
        {
			byteBlock.Write(装备容器);
			byteBlock.Write(装备位置);
			byteBlock.Write(当前持久);
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

