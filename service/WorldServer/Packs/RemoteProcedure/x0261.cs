#pragma warning disable CS8618

using TouchSocket.Core;
using WorldServer.Service;

namespace WorldServer.Packs.Protocol
{
    /// <summary>
    /// <para>删除外交公告</para>
    /// <para>删除外交公告</para>
    /// </summary>
    internal class x0261 : Package
    {
        #region public field

		public Byte 外交类型;
		public Int32 行会编号;
        #endregion

        #region public attribute

        public ushort Type => 0x0261;
        public ushort Size => 7;        
        #endregion
        
        #region private field


        #endregion

        public ByteBlock Marshal(ByteBlock byteBlock)
        {
			byteBlock.Write(外交类型);
			byteBlock.Write(行会编号);
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

