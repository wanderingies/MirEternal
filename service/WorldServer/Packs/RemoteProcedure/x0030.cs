#pragma warning disable CS8618

using TouchSocket.Core;
using WorldServer.Service;

namespace WorldServer.Packs.Protocol
{
    /// <summary>
    /// <para>角色停止</para>
    /// <para>ObjectCharacterStopPacket</para>
    /// </summary>
    internal class x0030 : Package
    {
        #region public field

		public Int32 对象编号;
		public Byte U1;
		public UInt16 对象高度;
        #endregion

        #region public attribute

        public ushort Type => 0x0030;
        public ushort Size => 13;        
        #endregion
        
        #region private field


        #endregion

        public ByteBlock Marshal(ByteBlock byteBlock)
        {
			byteBlock.Write(对象编号);
			byteBlock.Write(U1);
			byteBlock.Write(对象高度);
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

