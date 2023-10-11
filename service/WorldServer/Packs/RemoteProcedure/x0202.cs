#pragma warning disable CS8618

using TouchSocket.Core;
using WorldServer.Service;

namespace WorldServer.Packs.Protocol
{
    /// <summary>
    /// <para>聊天服务器错误提示</para>
    /// <para>社交错误提示</para>
    /// </summary>
    internal class x0202 : Package
    {
        #region public field

		public Int32 错误编号;
		public Int32 参数一;
		public Int32 参数二;
        #endregion

        #region public attribute

        public ushort Type => 0x0202;
        public ushort Size => 14;        
        #endregion
        
        #region private field


        #endregion

        public ByteBlock Marshal(ByteBlock byteBlock)
        {
			byteBlock.Write(错误编号);
			byteBlock.Write(参数一);
			byteBlock.Write(参数二);
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

