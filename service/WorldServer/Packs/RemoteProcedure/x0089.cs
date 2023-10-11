#pragma warning disable CS8618

using TouchSocket.Core;
using WorldServer.Service;

namespace WorldServer.Packs.Protocol
{
    /// <summary>
    /// <para>背包容量改变</para>
    /// <para>背包容量改变</para>
    /// </summary>
    internal class x0089 : Package
    {
        #region public field

		public Byte 背包类型;
		public Byte 背包容量;
        #endregion

        #region public attribute

        public ushort Type => 0x0089;
        public ushort Size => 4;        
        #endregion
        
        #region private field


        #endregion

        public ByteBlock Marshal(ByteBlock byteBlock)
        {
			byteBlock.Write(背包类型);
			byteBlock.Write(背包容量);
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

