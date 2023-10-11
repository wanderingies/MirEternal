#pragma warning disable CS8618

using TouchSocket.Core;
using WorldServer.Service;

namespace WorldServer.Packs.Protocol
{
    /// <summary>
    /// <para>ChestComesIntoViewPacket</para>
    /// <para>ChestComesIntoViewPacket</para>
    /// </summary>
    internal class x0099 : Package
    {
        #region public field

		public Int32 ObjectId;
		public Int32 NPCTemplateId;
		public UInt16 Altitude;
		public UInt16 Direction;
		public Boolean Interactive;
        #endregion

        #region public attribute

        public ushort Type => 0x0099;
        public ushort Size => 0;        
        #endregion
        
        #region private field


        #endregion

        public ByteBlock Marshal(ByteBlock byteBlock)
        {
			byteBlock.Write(ObjectId);
			byteBlock.Write(NPCTemplateId);
			byteBlock.Write(Altitude);
			byteBlock.Write(Direction);
			byteBlock.Write(Interactive);
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

