#pragma warning disable CS8618

using TouchSocket.Core;
using WorldServer.Service;

namespace WorldServer.Packs.Protocol
{
    /// <summary>
    /// <para>玩家镶嵌灵石</para>
    /// <para>成功镶嵌灵石</para>
    /// </summary>
    internal class x00FD : Package
    {
        #region public field

		public Byte 灵石状态;
        #endregion

        #region public attribute

        public ushort Type => 0x00FD;
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

