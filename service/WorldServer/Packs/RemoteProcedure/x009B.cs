#pragma warning disable CS8618

using TouchSocket.Core;
using WorldServer.Service;

namespace WorldServer.Packs.Protocol
{
    /// <summary>
    /// <para>EndOpenChestPacket</para>
    /// <para>EndOpenChestPacket</para>
    /// </summary>
    internal class x009B : Package
    {
        #region public field

		public Int32 PlayerId;
		public Int32 ObjectId;
		public Boolean Unknown;
        #endregion

        #region public attribute

        public ushort Type => 0x009B;
        public ushort Size => 11;        
        #endregion
        
        #region private field


        #endregion

        public ByteBlock Marshal(ByteBlock byteBlock)
        {
			byteBlock.Write(PlayerId);
			byteBlock.Write(ObjectId);
			byteBlock.Write(Unknown);
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

