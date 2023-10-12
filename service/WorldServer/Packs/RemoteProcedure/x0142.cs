#pragma warning disable CS8618

using TouchSocket.Core;
using WorldServer.Service;

namespace WorldServer.Packs.Protocol
{
    /// <summary>
    /// <para>SyncPrivilegedInfoPacket</para>
    /// <para>SyncPrivilegedInfoPacket</para>
    /// </summary>
    internal class x0142 : Package
    {
        #region public field

		public byte[] 字节数组;
        #endregion

        #region public attribute

        public ushort Type => 0x0142;
        public ushort Size => 0;        
        #endregion
        
        #region private field


        #endregion

        public ByteBlock Marshal(ByteBlock byteBlock)
        {
			byteBlock.Write(字节数组);
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

