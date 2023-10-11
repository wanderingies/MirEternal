#pragma warning disable CS8618

using TouchSocket.Core;
using WorldServer.Service;

namespace WorldServer.Packs.Protocol
{
    /// <summary>
    /// <para>申请Hostility应答</para>
    /// <para>申请Hostility应答</para>
    /// </summary>
    internal class x0282 : Package
    {
        #region public field

		public Int32 行会编号;
		public Int32 需要资金;
        #endregion

        #region public attribute

        public ushort Type => 0x0282;
        public ushort Size => 10;        
        #endregion
        
        #region private field


        #endregion

        public ByteBlock Marshal(ByteBlock byteBlock)
        {
			byteBlock.Write(行会编号);
			byteBlock.Write(需要资金);
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

