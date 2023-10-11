#pragma warning disable CS8618

using TouchSocket.Core;
using WorldServer.Service;

namespace WorldServer.Packs.Protocol
{
    /// <summary>
    /// <para>UnknownS3</para>
    /// <para>UnknownS222</para>
    /// </summary>
    internal class x00DE : Package
    {
        #region public field

		public Int32 U1;
		public Int32 U2;
        #endregion

        #region public attribute

        public ushort Type => 0x00DE;
        public ushort Size => 10;        
        #endregion
        
        #region private field


        #endregion

        public ByteBlock Marshal(ByteBlock byteBlock)
        {
			byteBlock.Write(U1);
			byteBlock.Write(U2);
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

