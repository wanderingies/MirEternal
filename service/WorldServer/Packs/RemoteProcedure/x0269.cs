#pragma warning disable CS8618

using TouchSocket.Core;
using WorldServer.Service;

namespace WorldServer.Packs.Protocol
{
    /// <summary>
    /// <para>AddGuildMemoPacket</para>
    /// <para>AddGuildMemoPacket</para>
    /// </summary>
    internal class x0269 : Package
    {
        #region public field

		public Byte MemorandumType;
		public Int32 第一参数;
		public Int32 第二参数;
		public Int32 第三参数;
		public Int32 第四参数;
		public Int32 事记时间;
        #endregion

        #region public attribute

        public ushort Type => 0x0269;
        public ushort Size => 23;        
        #endregion
        
        #region private field


        #endregion

        public ByteBlock Marshal(ByteBlock byteBlock)
        {
			byteBlock.Write(MemorandumType);
			byteBlock.Write(第一参数);
			byteBlock.Write(第二参数);
			byteBlock.Write(第三参数);
			byteBlock.Write(第四参数);
			byteBlock.Write(事记时间);
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

