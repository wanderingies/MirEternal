#pragma warning disable CS8618

using TouchSocket.Core;
using WorldServer.Service;

namespace WorldServer.Packs.Protocol
{
    /// <summary>
    /// <para>SyncCooldownListPacket</para>
    /// <para>SyncCooldownListPacket</para>
    /// </summary>
    internal class x006C : Package
    {
        #region public field

		public byte[] 字节描述;
        #endregion

        #region public attribute

        public ushort Type => 0x006C;
        public ushort Size => 0;        
        #endregion
        
        #region private field


        #endregion

        public ByteBlock Marshal(ByteBlock byteBlock)
        {
			byteBlock.Write(字节描述);
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

