#pragma warning disable CS8618

using TouchSocket.Core;
using GameServer.Service;

namespace GameServer.Packs.Protocol
{
    /// <summary>
    /// <para>更改存储权限</para>
    /// <para>更改存储权限</para>
    /// </summary>
    internal class x023C : Package
    {
        #region public field

		public Byte GuildJobs;
		public Byte 原有位置;
		public Byte 目标页面;
        #endregion

        #region public attribute

        public ushort Type => 0x023C;
        public ushort Size => 5;        
        #endregion
        
        #region private field


        #endregion

        public ByteBlock Marshal(ByteBlock byteBlock)
        {
            return byteBlock;
        }

        public ByteBlock UnMarshal(ByteBlock byteBlock)
        {
			GuildJobs = byteBlock.ReadByte();
			原有位置 = byteBlock.ReadByte();
			目标页面 = byteBlock.ReadByte();
            return byteBlock;
        }

        public void Process(GameSession session)
        {
            
        }
    }
}

