#pragma warning disable CS8618

using TouchSocket.Core;
using WorldServer.Service;

namespace WorldServer.Packs.Protocol
{
    /// <summary>
    /// <para>添加关注</para>
    /// <para>玩家添加关注</para>
    /// </summary>
    internal class x0214 : Package
    {
        #region public field

		public Int32 对象编号;
		public String 对象名字;
		public Boolean 是否好友;
        #endregion

        #region public attribute

        public ushort Type => 0x0214;
        public ushort Size => 39;        
        #endregion
        
        #region private field


        #endregion

        public ByteBlock Marshal(ByteBlock byteBlock)
        {
			byteBlock.Write(对象编号);
			byteBlock.Write(对象名字);
			byteBlock.Write(是否好友);
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

