#pragma warning disable CS8618

using TouchSocket.Core;
using WorldServer.Service;

namespace WorldServer.Packs.Protocol
{
    /// <summary>
    /// <para>同步角色外形</para>
    /// <para>同步角色外形</para>
    /// </summary>
    internal class x008A : Package
    {
        #region public field

		public Int32 对象编号;
		public Byte ItemType;
		public Int32 装备编号;
		public Byte 升级次数;
        #endregion

        #region public attribute

        public ushort Type => 0x008A;
        public ushort Size => 13;        
        #endregion
        
        #region private field


        #endregion

        public ByteBlock Marshal(ByteBlock byteBlock)
        {
			byteBlock.Write(对象编号);
			byteBlock.Write(ItemType);
			byteBlock.Write(装备编号);
			byteBlock.Write(升级次数);
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

