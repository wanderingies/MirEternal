#pragma warning disable CS8618

using TouchSocket.Core;
using WorldServer.Service;

namespace WorldServer.Packs.Protocol
{
    /// <summary>
    /// <para>Synchronous gateway ping</para>
    /// <para>LoginQueryResponsePacket</para>
    /// </summary>
    internal class x03F2 : Package
    {
        #region public field

		public Int32 当前时间;
        #endregion

        #region public attribute

        public ushort Type => 0x03F2;
        public ushort Size => 6;        
        #endregion
        
        #region private field


        #endregion

        public ByteBlock Marshal(ByteBlock byteBlock)
        {
			byteBlock.Write(当前时间);
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

