#pragma warning disable CS8618

using TouchSocket.Core;
using WorldServer.Service;

namespace WorldServer.Packs.Protocol
{
    /// <summary>
    /// <para>查看攻城名单</para>
    /// <para>查看攻城名单</para>
    /// </summary>
    internal class x011E : Package
    {
        #region public field

		public byte[] 字节描述;
        #endregion

        #region public attribute

        public ushort Type => 0x011E;
        public ushort Size => 0;        
        #endregion
        
        #region private field


        #endregion

        public ByteBlock Marshal(ByteBlock byteBlock)
        {
			byteBlock.Write(字节描述);
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

