#pragma warning disable CS8618

using TouchSocket.Core;
using GameServer.Service;

namespace GameServer.Packs.Protocol
{
    /// <summary>
    /// <para>申请行会Hostility</para>
    /// <para>申请行会Hostility</para>
    /// </summary>
    internal class x0248 : Package
    {
        #region public field

		public Byte Hostility时间;
		public String GuildName;
        #endregion

        #region public attribute

        public ushort Type => 0x0248;
        public ushort Size => 28;        
        #endregion
        
        #region private field


        #endregion

        public ByteBlock Marshal(ByteBlock byteBlock)
        {
            return byteBlock;
        }

        public ByteBlock UnMarshal(ByteBlock byteBlock)
        {
			Hostility时间 = byteBlock.ReadByte();
            return byteBlock;
        }

        public void Process(GameSession session)
        {
            
        }
    }
}

