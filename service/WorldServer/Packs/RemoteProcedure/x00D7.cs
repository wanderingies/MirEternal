#pragma warning disable CS8618

using TouchSocket.Core;
using WorldServer.Service;

namespace WorldServer.Packs.Protocol
{
    /// <summary>
    /// <para>TransactionStatusChangePacket</para>
    /// <para>TransactionStatusChangePacket</para>
    /// </summary>
    internal class x00D7 : Package
    {
        #region public field

		public Int32 对象编号;
		public Byte 交易状态;
		public Int32 对象等级;
        #endregion

        #region public attribute

        public ushort Type => 0x00D7;
        public ushort Size => 11;        
        #endregion
        
        #region private field


        #endregion

        public ByteBlock Marshal(ByteBlock byteBlock)
        {
			byteBlock.Write(对象编号);
			byteBlock.Write(交易状态);
			byteBlock.Write(对象等级);
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

