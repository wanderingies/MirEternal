#pragma warning disable CS8618

using TouchSocket.Core;
using WorldServer.Service;

namespace WorldServer.Packs.Protocol
{
    /// <summary>
    /// <para>玩家名字变灰</para>
    /// <para>玩家名字变灰</para>
    /// </summary>
    internal class x0052 : Package
    {
        #region public field

		public Int32 对象编号;
		public Boolean 是否灰名;
        #endregion

        #region public attribute

        public ushort Type => 0x0052;
        public ushort Size => 7;        
        #endregion
        
        #region private field


        #endregion

        public ByteBlock Marshal(ByteBlock byteBlock)
        {
			byteBlock.Write(对象编号);
			byteBlock.Write(是否灰名);
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

