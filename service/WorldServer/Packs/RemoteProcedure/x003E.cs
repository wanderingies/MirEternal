#pragma warning disable CS8618

using TouchSocket.Core;
using WorldServer.Service;

namespace WorldServer.Packs.Protocol
{
    /// <summary>
    /// <para>对象消失</para>
    /// <para>ObjectOutOfViewPacket</para>
    /// </summary>
    internal class x003E : Package
    {
        #region public field

		public Int32 对象编号;
		public Byte 消失方式;
        #endregion

        #region public attribute

        public ushort Type => 0x003E;
        public ushort Size => 7;        
        #endregion
        
        #region private field


        #endregion

        public ByteBlock Marshal(ByteBlock byteBlock)
        {
			byteBlock.Write(对象编号);
			byteBlock.Write(消失方式);
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

