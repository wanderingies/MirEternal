#pragma warning disable CS8618

using TouchSocket.Core;
using WorldServer.Service;

namespace WorldServer.Packs.Protocol
{
    /// <summary>
    /// <para>服务端提示</para>
    /// <para>GameErrorMessagePacket</para>
    /// </summary>
    internal class x0009 : Package
    {
        #region public field

		public Int32 错误代码;
		public Int32 第一参数;
		public Int32 第二参数;
        #endregion

        #region public attribute

        public ushort Type => 0x0009;
        public ushort Size => 14;        
        #endregion
        
        #region private field


        #endregion

        public ByteBlock Marshal(ByteBlock byteBlock)
        {
			byteBlock.Write(错误代码);
			byteBlock.Write(第一参数);
			byteBlock.Write(第二参数);
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

