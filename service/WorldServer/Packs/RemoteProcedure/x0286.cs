#pragma warning disable CS8618

using TouchSocket.Core;
using WorldServer.Service;

namespace WorldServer.Packs.Protocol
{
    /// <summary>
    /// <para>SyncMemberInfoPacket</para>
    /// <para>SyncMemberInfoPacket</para>
    /// </summary>
    internal class x0286 : Package
    {
        #region public field

		public Int32 对象编号;
		public Int32 对象信息;
		public Byte CurrentRank;
        #endregion

        #region public attribute

        public ushort Type => 0x0286;
        public ushort Size => 11;        
        #endregion
        
        #region private field


        #endregion

        public ByteBlock Marshal(ByteBlock byteBlock)
        {
			byteBlock.Write(对象编号);
			byteBlock.Write(对象信息);
			byteBlock.Write(CurrentRank);
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

