#pragma warning disable CS8618

using TouchSocket.Core;
using GameServer.Service;

namespace GameServer.Packs.Protocol
{
    /// <summary>
    /// <para>服务端提示</para>
    /// <para>GameErrorMessagePacket</para>
    /// </summary>
    internal class x0009 : Package
    {
        #region public field

		public Int32 code;
		public Int32 param;
		public Int32 extra;
        #endregion

        #region public attribute

        public ushort Type => 0x0009;
        public ushort Size => 14;
        public ushort rSize => 14;
        #endregion

        #region private field


        #endregion

        public ByteBlock Marshal(ByteBlock byteBlock)
        {
			byteBlock.Write(code);
			byteBlock.Write(param);
			byteBlock.Write(extra);
            return byteBlock;
        }

        public ByteBlock UnMarshal(ByteBlock byteBlock)
        {
            return byteBlock;
        }

        public void Process(GameSession session)
        {
            
        }
    }
}

