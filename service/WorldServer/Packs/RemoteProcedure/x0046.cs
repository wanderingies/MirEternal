#pragma warning disable CS8618

using TouchSocket.Core;
using WorldServer.Service;

namespace WorldServer.Packs.Protocol
{
    /// <summary>
    /// <para>同步道具次数</para>
    /// <para>同步道具次数</para>
    /// </summary>
    internal class x0046 : Package
    {
        #region public field

		public Int32 ObjectId;
		public Int32 PlayerId;
		public Byte Unknown;
        #endregion

        #region public attribute

        public ushort Type => 0x0046;
        public ushort Size => 11;        
        #endregion
        
        #region private field


        #endregion

        public ByteBlock Marshal(ByteBlock byteBlock)
        {
			byteBlock.Write(ObjectId);
			byteBlock.Write(PlayerId);
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

