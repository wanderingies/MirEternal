#pragma warning disable CS8618

using TouchSocket.Core;
using WorldServer.Service;

namespace WorldServer.Packs.Protocol
{
    /// <summary>
    /// <para>会长传位公告</para>
    /// <para>会长传位公告</para>
    /// </summary>
    internal class x025A : Package
    {
        #region public field

		public Int32 当前编号;
		public Int32 传位编号;
        #endregion

        #region public attribute

        public ushort Type => 0x025A;
        public ushort Size => 10;        
        #endregion
        
        #region private field


        #endregion

        public ByteBlock Marshal(ByteBlock byteBlock)
        {
			byteBlock.Write(当前编号);
			byteBlock.Write(传位编号);
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

