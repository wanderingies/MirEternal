#pragma warning disable CS8618

using TouchSocket.Core;
using GameServer.Service;

namespace GameServer.Packs.Protocol
{
    /// <summary>
    /// <para>创建角色</para>
    /// <para>UserCreateRolePacket</para>
    /// </summary>
    internal class x03EA : Package
    {
        #region public field

		public String name;
		public Byte gender;
		public Byte career;
		public Byte hairstyle;
		public Byte haircolor;
		public Byte facestyle;
        #endregion

        #region public attribute

        public ushort Type => 0x03EA;
        public ushort Size => 40;        
        #endregion
        
        #region private field


        #endregion

        public ByteBlock Marshal(ByteBlock byteBlock)
        {
            return byteBlock;
        }

        public ByteBlock UnMarshal(ByteBlock byteBlock)
        {
			gender = byteBlock.ReadByte();
			career = byteBlock.ReadByte();
			hairstyle = byteBlock.ReadByte();
			haircolor = byteBlock.ReadByte();
			facestyle = byteBlock.ReadByte();
            return byteBlock;
        }

        public void Process(GameSession session)
        {
            
        }
    }
}

