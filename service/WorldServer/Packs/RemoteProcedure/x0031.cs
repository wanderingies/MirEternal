#pragma warning disable CS8618

using TouchSocket.Core;
using WorldServer.Service;

namespace WorldServer.Packs.Protocol
{
    /// <summary>
    /// <para>被动位移</para>
    /// <para>ObjectPassiveDisplacementPacket</para>
    /// </summary>
    internal class x0031 : Package
    {
        #region public field

		public Int32 对象编号;
		public Byte 第一标记;
		public UInt16 第二标记;
		public UInt16 位移朝向;
		public UInt16 位移速度;
        #endregion

        #region public attribute

        public ushort Type => 0x0031;
        public ushort Size => 17;        
        #endregion
        
        #region private field


        #endregion

        public ByteBlock Marshal(ByteBlock byteBlock)
        {
			byteBlock.Write(对象编号);
			byteBlock.Write(第一标记);
			byteBlock.Write(第二标记);
			byteBlock.Write(位移朝向);
			byteBlock.Write(位移速度);
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

