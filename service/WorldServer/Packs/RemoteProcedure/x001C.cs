#pragma warning disable CS8618

using TouchSocket.Core;
using WorldServer.Service;

namespace WorldServer.Packs.Protocol
{
    /// <summary>
    /// <para>SyncMountDataPacket</para>
    /// <para>SyncMountDataPacket</para>
    /// </summary>
    internal class x001C : Package
    {
        #region public field

		public Int32 Unknown1;
		public Int32 Unknown2;
		public UInt16 Unknown3;
		public byte[] MountData;
        #endregion

        #region public attribute

        public ushort Type => 0x001C;
        public ushort Size => 0;        
        #endregion
        
        #region private field


        #endregion

        public ByteBlock Marshal(ByteBlock byteBlock)
        {
			byteBlock.Write(Unknown1);
			byteBlock.Write(Unknown2);
			byteBlock.Write(Unknown3);
			byteBlock.Write(MountData);
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

