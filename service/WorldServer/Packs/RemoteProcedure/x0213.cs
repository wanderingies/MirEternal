#pragma warning disable CS8618

using TouchSocket.Core;
using WorldServer.Service;

namespace WorldServer.Packs.Protocol
{
    /// <summary>
    /// <para>好友上下线</para>
    /// <para>好友上线下线</para>
    /// </summary>
    internal class x0213 : Package
    {
        #region public field

		public Int32 对象编号;
		public String 对象名字;
		public Byte 对象职业;
		public Byte 对象性别;
		public Byte 上线下线;
        #endregion

        #region public attribute

        public ushort Type => 0x0213;
        public ushort Size => 0;        
        #endregion
        
        #region private field


        #endregion

        public ByteBlock Marshal(ByteBlock byteBlock)
        {
			byteBlock.Write(对象编号);
			byteBlock.Write(对象名字);
			byteBlock.Write(对象职业);
			byteBlock.Write(对象性别);
			byteBlock.Write(上线下线);
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

