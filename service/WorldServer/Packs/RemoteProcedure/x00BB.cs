#pragma warning disable CS8618

using TouchSocket.Core;
using WorldServer.Service;

namespace WorldServer.Packs.Protocol
{
    /// <summary>
    /// <para>SyncClientVariablesPacket</para>
    /// <para>SyncSupplementaryVariablesPacket</para>
    /// </summary>
    internal class x00BB : Package
    {
        #region public field

		public Byte 变量类型;
		public UInt16 变量索引;
		public Int32 对象编号;
		public Int32 变量内容;
        #endregion

        #region public attribute

        public ushort Type => 0x00BB;
        public ushort Size => 13;        
        #endregion
        
        #region private field


        #endregion

        public ByteBlock Marshal(ByteBlock byteBlock)
        {
			byteBlock.Write(变量类型);
			byteBlock.Write(变量索引);
			byteBlock.Write(对象编号);
			byteBlock.Write(变量内容);
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

