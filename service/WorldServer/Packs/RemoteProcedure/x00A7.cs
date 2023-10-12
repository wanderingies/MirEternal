#pragma warning disable CS8618

using TouchSocket.Core;
using WorldServer.Service;

namespace WorldServer.Packs.Protocol
{
    /// <summary>
    /// <para>Npcc交互结果</para>
    /// <para>同步交互结果</para>
    /// </summary>
    internal class x00A7 : Package
    {
        #region public field

		public Int32 对象编号;
		public byte[] 交互文本;
        #endregion

        #region public attribute

        public ushort Type => 0x00A7;
        public ushort Size => 0;        
        #endregion
        
        #region private field


        #endregion

        public ByteBlock Marshal(ByteBlock byteBlock)
        {
			byteBlock.Write(对象编号);
			byteBlock.Write(交互文本);
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

