#pragma warning disable CS8618

using TouchSocket.Core;
using WorldServer.Service;

namespace WorldServer.Packs.Protocol
{
    /// <summary>
    /// <para>更改摊位名字</para>
    /// <para>变更摊位名字</para>
    /// </summary>
    internal class x009F : Package
    {
        #region public field

		public Int32 对象编号;
		public String 摊位名字;
        #endregion

        #region public attribute

        public ushort Type => 0x009F;
        public ushort Size => 39;        
        #endregion
        
        #region private field


        #endregion

        public ByteBlock Marshal(ByteBlock byteBlock)
        {
			byteBlock.Write(对象编号);
			byteBlock.Write(摊位名字);
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

