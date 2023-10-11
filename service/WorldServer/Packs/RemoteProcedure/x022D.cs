#pragma warning disable CS8618

using TouchSocket.Core;
using WorldServer.Service;

namespace WorldServer.Packs.Protocol
{
    /// <summary>
    /// <para>申请收徒提示</para>
    /// <para>申请收徒提示</para>
    /// </summary>
    internal class x022D : Package
    {
        #region public field

		public Byte 面板类型;
		public Byte 对象等级;
		public Int32 对象编号;
		public Int32 对象声望;
        #endregion

        #region public attribute

        public ushort Type => 0x022D;
        public ushort Size => 12;        
        #endregion
        
        #region private field


        #endregion

        public ByteBlock Marshal(ByteBlock byteBlock)
        {
			byteBlock.Write(面板类型);
			byteBlock.Write(对象等级);
			byteBlock.Write(对象编号);
			byteBlock.Write(对象声望);
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

