#pragma warning disable CS8618

using TouchSocket.Core;
using WorldServer.Service;

namespace WorldServer.Packs.Protocol
{
    /// <summary>
    /// <para>添加BUFF</para>
    /// <para>ObjectAddStatePacket</para>
    /// </summary>
    internal class x0074 : Package
    {
        #region public field

		public Int32 SourceObjectId;
		public UInt16 BuffId;
		public Int32 BuffIndex;
		public Int32 TargetObjectId;
		public Int32 Duration;
		public Byte BuffLayers;
        #endregion

        #region public attribute

        public ushort Type => 0x0074;
        public ushort Size => 21;        
        #endregion
        
        #region private field


        #endregion

        public ByteBlock Marshal(ByteBlock byteBlock)
        {
			byteBlock.Write(SourceObjectId);
			byteBlock.Write(BuffId);
			byteBlock.Write(BuffIndex);
			byteBlock.Write(TargetObjectId);
			byteBlock.Write(Duration);
			byteBlock.Write(BuffLayers);
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

