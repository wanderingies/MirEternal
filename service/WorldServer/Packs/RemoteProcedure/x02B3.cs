#pragma warning disable CS8618

using TouchSocket.Core;
using WorldServer.Service;

namespace WorldServer.Packs.Protocol
{
    /// <summary>
    /// <para>UnknownS1</para>
    /// <para>UnknownS691</para>
    /// </summary>
    internal class x02B3 : Package
    {
        #region public field

		public UInt16 U1;
		public UInt16 U2;
		public UInt16 U3;
		public UInt16 U4;
		public UInt16 U5;
		public UInt16 U6;
		public UInt16 U7;
        #endregion

        #region public attribute

        public ushort Type => 0x02B3;
        public ushort Size => 16;        
        #endregion
        
        #region private field


        #endregion

        public ByteBlock Marshal(ByteBlock byteBlock)
        {
			byteBlock.Write(U1);
			byteBlock.Write(U2);
			byteBlock.Write(U3);
			byteBlock.Write(U4);
			byteBlock.Write(U5);
			byteBlock.Write(U6);
			byteBlock.Write(U7);
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

