#pragma warning disable CS8618

using TouchSocket.Core;
using WorldServer.Service;

namespace WorldServer.Packs.Protocol
{
    /// <summary>
    /// <para>SyncNPCData</para>
    /// <para>SyncNPCData</para>
    /// </summary>
    internal class x0041 : Package
    {
        #region public field

		public Int32 ObjectId;
		public UInt16 ObjectTemplate;
		public Byte ObjectMass;
		public Byte ObjectClass;
		public Int32 MaxHP;
        #endregion

        #region public attribute

        public ushort Type => 0x0041;
        public ushort Size => 16;        
        #endregion
        
        #region private field


        #endregion

        public ByteBlock Marshal(ByteBlock byteBlock)
        {
			byteBlock.Write(ObjectId);
			byteBlock.Write(ObjectTemplate);
			byteBlock.Write(ObjectMass);
			byteBlock.Write(ObjectClass);
			byteBlock.Write(MaxHP);
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

