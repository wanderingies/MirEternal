#pragma warning disable CS8618

using TouchSocket.Core;
using WorldServer.Service;

namespace WorldServer.Packs.Protocol
{
    /// <summary>
    /// <para>同步游戏ping</para>
    /// <para>InternetSpeedTestPacket</para>
    /// </summary>
    internal class x002D : Package
    {
        #region public field

		public Int32 当前时间;
        #endregion

        #region public attribute

        public ushort Type => 0x002D;
        public ushort Size => 6;        
        #endregion
        
        #region private field


        #endregion

        public ByteBlock Marshal(ByteBlock byteBlock)
        {
			byteBlock.Write(当前时间);
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

