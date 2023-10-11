#pragma warning disable CS8618

using TouchSocket.Core;
using WorldServer.Service;

namespace WorldServer.Packs.Protocol
{
    /// <summary>
    /// <para>SendTeamRequestBPacket</para>
    /// <para>SendTeamRequestBPacket</para>
    /// </summary>
    internal class x0208 : Package
    {
        #region public field

		public Int32 对象编号;
		public Byte 组队方式;
		public Byte 对象职业;
		public String 对象名字;
        #endregion

        #region public attribute

        public ushort Type => 0x0208;
        public ushort Size => 40;        
        #endregion
        
        #region private field


        #endregion

        public ByteBlock Marshal(ByteBlock byteBlock)
        {
			byteBlock.Write(对象编号);
			byteBlock.Write(组队方式);
			byteBlock.Write(对象职业);
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

