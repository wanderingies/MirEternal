#pragma warning disable CS8618

using TouchSocket.Core;
using WorldServer.Service;

namespace WorldServer.Packs.Protocol
{
    /// <summary>
    /// <para>同步PK模式</para>
    /// <para>同步对战模式</para>
    /// </summary>
    internal class x006E : Package
    {
        #region public field

		public Int32 对象编号;
		public Byte AttackMode;
        #endregion

        #region public attribute

        public ushort Type => 0x006E;
        public ushort Size => 7;        
        #endregion
        
        #region private field


        #endregion

        public ByteBlock Marshal(ByteBlock byteBlock)
        {
			byteBlock.Write(对象编号);
			byteBlock.Write(AttackMode);
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

