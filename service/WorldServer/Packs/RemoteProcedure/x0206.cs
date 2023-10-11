#pragma warning disable CS8618

using TouchSocket.Core;
using WorldServer.Service;

namespace WorldServer.Packs.Protocol
{
    /// <summary>
    /// <para>AddMembersToTeamPacket</para>
    /// <para>AddMembersToTeamPacket</para>
    /// </summary>
    internal class x0206 : Package
    {
        #region public field

		public Int32 队伍编号;
		public Int32 对象编号;
		public String 对象名字;
		public Byte 对象性别;
		public Byte 对象职业;
		public Byte 在线离线;
        #endregion

        #region public attribute

        public ushort Type => 0x0206;
        public ushort Size => 45;        
        #endregion
        
        #region private field


        #endregion

        public ByteBlock Marshal(ByteBlock byteBlock)
        {
			byteBlock.Write(队伍编号);
			byteBlock.Write(对象编号);
			byteBlock.Write(对象名字);
			byteBlock.Write(对象性别);
			byteBlock.Write(对象职业);
			byteBlock.Write(在线离线);
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

