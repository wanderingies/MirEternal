#pragma warning disable CS8618

using TouchSocket.Core;
using WorldServer.Service;

namespace WorldServer.Packs.Protocol
{
    /// <summary>
    /// <para>QueryMailboxContentPacket</para>
    /// <para>同步邮箱内容</para>
    /// </summary>
    internal class x023E : Package
    {
        #region public field

		public byte[] 字节数据;
        #endregion

        #region public attribute

        public ushort Type => 0x023E;
        public ushort Size => 0;        
        #endregion
        
        #region private field


        #endregion

        public ByteBlock Marshal(ByteBlock byteBlock)
        {
			byteBlock.Write(字节数据);
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

