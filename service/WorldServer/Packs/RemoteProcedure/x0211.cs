#pragma warning disable CS8618

using TouchSocket.Core;
using WorldServer.Service;

namespace WorldServer.Packs.Protocol
{
    /// <summary>
    /// <para>UnknownS3</para>
    /// <para>UnknownS529</para>
    /// </summary>
    internal class x0211 : Package
    {
        #region public field

		public byte[] Data;
        #endregion

        #region public attribute

        public ushort Type => 0x0211;
        public ushort Size => 39;        
        #endregion
        
        #region private field


        #endregion

        public ByteBlock Marshal(ByteBlock byteBlock)
        {
			byteBlock.Write(Data);
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

