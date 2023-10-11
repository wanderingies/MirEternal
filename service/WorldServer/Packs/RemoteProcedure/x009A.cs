#pragma warning disable CS8618

using TouchSocket.Core;
using WorldServer.Service;

namespace WorldServer.Packs.Protocol
{
    /// <summary>
    /// <para>开始操作道具</para>
    /// <para>StartOpenChestPacket</para>
    /// </summary>
    internal class x009A : Package
    {
        #region public field

		public Int32 PlayerId;
		public Int32 ObjectId;
		public UInt16 Duration;
        #endregion

        #region public attribute

        public ushort Type => 0x009A;
        public ushort Size => 12;        
        #endregion
        
        #region private field


        #endregion

        public ByteBlock Marshal(ByteBlock byteBlock)
        {
			byteBlock.Write(PlayerId);
			byteBlock.Write(ObjectId);
			byteBlock.Write(Duration);
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

