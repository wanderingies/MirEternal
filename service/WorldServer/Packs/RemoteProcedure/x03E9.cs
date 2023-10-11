#pragma warning disable CS8618

using TouchSocket.Core;
using WorldServer.Service;

namespace WorldServer.Packs.Protocol
{
    /// <summary>
    /// <para>Logging on to the server, error message</para>
    /// <para>LoginErrorMessagePacket</para>
    /// </summary>
    internal class x03E9 : Package
    {
        #region public field

		public UInt32 错误代码;
		public Int32 参数一;
		public Int32 参数二;
        #endregion

        #region public attribute

        public ushort Type => 0x03E9;
        public ushort Size => 14;        
        #endregion
        
        #region private field


        #endregion

        public ByteBlock Marshal(ByteBlock byteBlock)
        {
			byteBlock.Write(错误代码);
			byteBlock.Write(参数一);
			byteBlock.Write(参数二);
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

