#pragma warning disable CS8618

using TouchSocket.Core;
using WorldServer.Service;

namespace WorldServer.Packs.Protocol
{
    /// <summary>
    /// <para>SyncObjectHP</para>
    /// <para>SyncObjectHP</para>
    /// </summary>
    internal class x004E : Package
    {
        #region public field

		public Int32 ObjectId;
		public Int32 CurrentHP;
		public Int32 MaxHP;
        #endregion

        #region public attribute

        public ushort Type => 0x004E;
        public ushort Size => 14;        
        #endregion
        
        #region private field


        #endregion

        public ByteBlock Marshal(ByteBlock byteBlock)
        {
			byteBlock.Write(ObjectId);
			byteBlock.Write(CurrentHP);
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

