#pragma warning disable CS8618

using TouchSocket.Core;
using WorldServer.Service;

namespace WorldServer.Packs.Protocol
{
    /// <summary>
    /// <para>变更职位公告</para>
    /// <para>变更职位公告</para>
    /// </summary>
    internal class x0257 : Package
    {
        #region public field

		public Int32 对象编号;
		public Byte 对象职位;
        #endregion

        #region public attribute

        public ushort Type => 0x0257;
        public ushort Size => 7;        
        #endregion
        
        #region private field


        #endregion

        public ByteBlock Marshal(ByteBlock byteBlock)
        {
			byteBlock.Write(对象编号);
			byteBlock.Write(对象职位);
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

