#pragma warning disable CS8618

using TouchSocket.Core;
using WorldServer.Service;

namespace WorldServer.Packs.Protocol
{
    /// <summary>
    /// <para>陷阱出现</para>
    /// <para>TrapComesIntoViewPacket</para>
    /// </summary>
    internal class x007B : Package
    {
        #region public field

		public Int32 MapId;
		public Int32 来源编号;
		public UInt16 Id;
		public UInt16 陷阱高度;
		public UInt16 持续时间;
		public UInt16 未知参数;
		public UInt16 未知高度;
        #endregion

        #region public attribute

        public ushort Type => 0x007B;
        public ushort Size => 30;        
        #endregion
        
        #region private field


        #endregion

        public ByteBlock Marshal(ByteBlock byteBlock)
        {
			byteBlock.Write(MapId);
			byteBlock.Write(来源编号);
			byteBlock.Write(Id);
			byteBlock.Write(陷阱高度);
			byteBlock.Write(持续时间);
			byteBlock.Write(未知参数);
			byteBlock.Write(未知高度);
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

