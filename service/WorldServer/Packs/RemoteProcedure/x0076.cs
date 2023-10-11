#pragma warning disable CS8618

using TouchSocket.Core;
using WorldServer.Service;

namespace WorldServer.Packs.Protocol
{
    /// <summary>
    /// <para>BUFF变动</para>
    /// <para>ObjectStateChangePacket</para>
    /// </summary>
    internal class x0076 : Package
    {
        #region public field

		public Int32 对象编号;
		public UInt16 Id;
		public Int32 Buff索引;
		public Byte 当前层数;
		public Int32 剩余时间;
		public Int32 持续时间;
        #endregion

        #region public attribute

        public ushort Type => 0x0076;
        public ushort Size => 21;        
        #endregion
        
        #region private field


        #endregion

        public ByteBlock Marshal(ByteBlock byteBlock)
        {
			byteBlock.Write(对象编号);
			byteBlock.Write(Id);
			byteBlock.Write(Buff索引);
			byteBlock.Write(当前层数);
			byteBlock.Write(剩余时间);
			byteBlock.Write(持续时间);
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

