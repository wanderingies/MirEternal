#pragma warning disable CS8618

using TouchSocket.Core;
using WorldServer.Service;

namespace WorldServer.Packs.Protocol
{
    /// <summary>
    /// <para>玩家取下灵石</para>
    /// <para>成功取下灵石</para>
    /// </summary>
    internal class x00FE : Package
    {
        #region public field

		public Byte 灵石状态;
        #endregion

        #region public attribute

        public ushort Type => 0x00FE;
        public ushort Size => 3;        
        #endregion
        
        #region private field


        #endregion

        public ByteBlock Marshal(ByteBlock byteBlock)
        {
			byteBlock.Write(灵石状态);
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

