#pragma warning disable CS8618

using TouchSocket.Core;
using WorldServer.Service;

namespace WorldServer.Packs.Protocol
{
    /// <summary>
    /// <para>移除BUFF</para>
    /// <para>ObjectRemovalStatusPacket</para>
    /// </summary>
    internal class x0075 : Package
    {
        #region public field

		public Int32 对象编号;
		public Int32 Buff索引;
        #endregion

        #region public attribute

        public ushort Type => 0x0075;
        public ushort Size => 10;        
        #endregion
        
        #region private field


        #endregion

        public ByteBlock Marshal(ByteBlock byteBlock)
        {
			byteBlock.Write(对象编号);
			byteBlock.Write(Buff索引);
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

