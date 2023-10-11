#pragma warning disable CS8618

using TouchSocket.Core;
using WorldServer.Service;

namespace WorldServer.Packs.Protocol
{
    /// <summary>
    /// <para>玩家屏蔽目标</para>
    /// <para>玩家屏蔽目标</para>
    /// </summary>
    internal class x00FA : Package
    {
        #region public field

		public Int32 对象编号;
		public String 对象名字;
        #endregion

        #region public attribute

        public ushort Type => 0x00FA;
        public ushort Size => 38;        
        #endregion
        
        #region private field


        #endregion

        public ByteBlock Marshal(ByteBlock byteBlock)
        {
			byteBlock.Write(对象编号);
			byteBlock.Write(对象名字);
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

