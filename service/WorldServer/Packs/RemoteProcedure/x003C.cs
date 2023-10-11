#pragma warning disable CS8618

using TouchSocket.Core;
using WorldServer.Service;

namespace WorldServer.Packs.Protocol
{
    /// <summary>
    /// <para>对象出现, 适用于对象主动进入视野</para>
    /// <para>ObjectComesIntoViewPacket</para>
    /// </summary>
    internal class x003C : Package
    {
        #region public field

		public Byte 出现方式;
		public Int32 对象编号;
		public Byte 现身姿态;
		public UInt16 现身高度;
		public UInt16 现身方向;
		public Byte 体力比例;
		public Byte ActiveMount;
		public Byte U1;
		public Byte AdditionalParam;
        #endregion

        #region public attribute

        public ushort Type => 0x003C;
        public ushort Size => 20;        
        #endregion
        
        #region private field


        #endregion

        public ByteBlock Marshal(ByteBlock byteBlock)
        {
			byteBlock.Write(出现方式);
			byteBlock.Write(对象编号);
			byteBlock.Write(现身姿态);
			byteBlock.Write(现身高度);
			byteBlock.Write(现身方向);
			byteBlock.Write(体力比例);
			byteBlock.Write(ActiveMount);
			byteBlock.Write(U1);
			byteBlock.Write(AdditionalParam);
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

