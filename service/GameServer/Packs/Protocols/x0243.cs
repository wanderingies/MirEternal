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
        #region public

		public String GuildName;
        #endregion

        #region marshal


        #endregion

        #region attribute

        public ushort Type => 0x0243;
        public ushort Size => 27;     
        public ushort rSize => 0;
        #endregion
        
        public x0243() 
        {
        }

        #region private


        #endregion

        public ByteBlock Marshal(ByteBlock byteBlock)
        {
            throw new NotImplementedException();
        }

        public ByteBlock UnMarshal(ByteBlock byteBlock)
        {
			throw new NotImplementedException();
        }

        public void Process(GameSession gameSession)
        {
            throw new NotImplementedException();
        }
    }
}

