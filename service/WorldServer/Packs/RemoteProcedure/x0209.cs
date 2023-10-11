#pragma warning disable CS8618

using TouchSocket.Core;
using WorldServer.Service;

namespace WorldServer.Packs.Protocol
{
    /// <summary>
    /// <para>TeamStatusChangePacket</para>
    /// <para>TeamStatusChangePacket</para>
    /// </summary>
    internal class x0209 : Package
    {
        #region public field

		public Int32 队伍编号;
		public String 队伍名字;
		public Int32 成员上限;
		public Byte 分配方式;
		public Int32 队长编号;
        #endregion

        #region public attribute

        public ushort Type => 0x0209;
        public ushort Size => 52;        
        #endregion
        
        #region private field


        #endregion

        public ByteBlock Marshal(ByteBlock byteBlock)
        {
			byteBlock.Write(队伍编号);
			byteBlock.Write(队伍名字);
			byteBlock.Write(成员上限);
			byteBlock.Write(分配方式);
			byteBlock.Write(队长编号);
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

