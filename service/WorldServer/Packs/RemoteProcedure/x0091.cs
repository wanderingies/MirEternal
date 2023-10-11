#pragma warning disable CS8618

using TouchSocket.Core;
using WorldServer.Service;

namespace WorldServer.Packs.Protocol
{
    /// <summary>
    /// <para>SyncObjectMountPacket</para>
    /// <para>SyncObjectMountPacket</para>
    /// </summary>
    internal class x0091 : Package
    {
        #region public field

		public Int32 ObjectId;
		public Byte MountId;
        #endregion

        #region public attribute

        public ushort Type => 0x0091;
        public ushort Size => 7;        
        #endregion
        
        #region private field


        #endregion

        public ByteBlock Marshal(ByteBlock byteBlock)
        {
			byteBlock.Write(ObjectId);
			byteBlock.Write(MountId);
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

