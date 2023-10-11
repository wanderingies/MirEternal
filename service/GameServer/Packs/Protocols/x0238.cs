#pragma warning disable CS8618

using TouchSocket.Core;
using GameServer.Service;

namespace GameServer.Packs.Protocol
{
    /// <summary>
    /// <para>申请行会外交</para>
    /// <para>申请行会外交</para>
    /// </summary>
    internal class x0238 : Package
    {
        #region public field

		public Byte 外交类型;
		public Byte 外交时间;
		public String GuildName;
        #endregion

        #region public attribute

        public ushort Type => 0x0238;
        public ushort Size => 29;        
        #endregion
        
        #region private field


        #endregion

        public ByteBlock Marshal(ByteBlock byteBlock)
        {
            return byteBlock;
        }

        public ByteBlock UnMarshal(ByteBlock byteBlock)
        {
			外交类型 = byteBlock.ReadByte();
			外交时间 = byteBlock.ReadByte();
            return byteBlock;
        }

        public void Process(GameSession session)
        {
            
        }
    }
}

