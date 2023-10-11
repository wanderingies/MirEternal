#pragma warning disable CS8618

using TouchSocket.Core;
using WorldServer.Service;

namespace WorldServer.Packs.Protocol
{
    /// <summary>
    /// <para>体力变动飘字</para>
    /// <para>体力变动飘字</para>
    /// </summary>
    internal class x0068 : Package
    {
        #region public field

		public Int32 对象编号;
		public Int32 血量变化;
        #endregion

        #region public attribute

        public ushort Type => 0x0068;
        public ushort Size => 10;        
        #endregion
        
        #region private field


        #endregion

        public ByteBlock Marshal(ByteBlock byteBlock)
        {
			byteBlock.Write(对象编号);
			byteBlock.Write(血量变化);
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

