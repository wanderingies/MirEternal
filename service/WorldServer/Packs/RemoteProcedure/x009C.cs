#pragma warning disable CS8618

using TouchSocket.Core;
using WorldServer.Service;

namespace WorldServer.Packs.Protocol
{
    /// <summary>
    /// <para>摆摊状态改变</para>
    /// <para>摆摊状态改变</para>
    /// </summary>
    internal class x009C : Package
    {
        #region public field

		public Int32 对象编号;
		public Byte 摊位状态;
        #endregion

        #region public attribute

        public ushort Type => 0x009C;
        public ushort Size => 7;        
        #endregion
        
        #region private field


        #endregion

        public ByteBlock Marshal(ByteBlock byteBlock)
        {
			byteBlock.Write(对象编号);
			byteBlock.Write(摊位状态);
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

