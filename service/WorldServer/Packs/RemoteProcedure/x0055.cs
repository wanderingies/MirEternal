#pragma warning disable CS8618

using TouchSocket.Core;
using WorldServer.Service;

namespace WorldServer.Packs.Protocol
{
    /// <summary>
    /// <para>泡泡提示</para>
    /// <para>同步气泡提示</para>
    /// </summary>
    internal class x0055 : Package
    {
        #region public field

		public UInt16 泡泡类型;
		public Int32 泡泡参数;
        #endregion

        #region public attribute

        public ushort Type => 0x0055;
        public ushort Size => 8;        
        #endregion
        
        #region private field


        #endregion

        public ByteBlock Marshal(ByteBlock byteBlock)
        {
			byteBlock.Write(泡泡类型);
			byteBlock.Write(泡泡参数);
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

