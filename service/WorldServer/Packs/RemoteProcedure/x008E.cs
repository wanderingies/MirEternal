#pragma warning disable CS8618

using TouchSocket.Core;
using WorldServer.Service;

namespace WorldServer.Packs.Protocol
{
    /// <summary>
    /// <para>同步商店版本</para>
    /// <para>SyncStoreDataPacket</para>
    /// </summary>
    internal class x008E : Package
    {
        #region public field

		public Int32 StoreVersion;
		public Int32 ItemsCount;
		public byte[] Data;
        #endregion

        #region public attribute

        public ushort Type => 0x008E;
        public ushort Size => 0;        
        #endregion
        
        #region private field


        #endregion

        public ByteBlock Marshal(ByteBlock byteBlock)
        {
			byteBlock.Write(StoreVersion);
			byteBlock.Write(ItemsCount);
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

