#pragma warning disable CS8618

using TouchSocket.Core;
using GameServer.Service;

namespace GameServer.Packs.Protocol
{
    /// <summary>
    /// <para>StartGuildWarPacket</para>
    /// <para>StartGuildWarPacket</para>
    /// </summary>
    internal class x0243 : Package
    {
        #region public field

		public String GuildName;
        #endregion

        #region public attribute

        public ushort Type => 0x0243;
        public ushort Size => 27;        
        #endregion
        
        #region private field


        #endregion

        public ByteBlock Marshal(ByteBlock byteBlock)
        {
            return byteBlock;
        }

        public ByteBlock UnMarshal(ByteBlock byteBlock)
        {
            return byteBlock;
        }

        public void Process(GameSession session)
        {
            
        }
    }
}

