#pragma warning disable CS8618

using TouchSocket.Core;
using WorldServer.Service;

namespace WorldServer.Packs.Protocol
{
    /// <summary>
    /// <para>陷阱移动</para>
    /// <para>TrapMoveLocationPacket</para>
    /// </summary>
    internal class x007C : Package
    {
        #region public field

		public Int32 Id;
		public UInt16 移动速度;
		public Int32 未知参数;
		public UInt16 移动高度;
        #endregion

        #region public attribute

        public ushort Type => 0x007C;
        public ushort Size => 18;        
        #endregion
        
        #region private field


        #endregion

        public ByteBlock Marshal(ByteBlock byteBlock)
        {
			byteBlock.Write(Id);
			byteBlock.Write(移动速度);
			byteBlock.Write(未知参数);
			byteBlock.Write(移动高度);
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

