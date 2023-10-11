#pragma warning disable CS8618

using TouchSocket.Core;
using WorldServer.Service;

namespace WorldServer.Packs.Protocol
{
    /// <summary>
    /// <para>GuildDiplomaticAnnouncementPacket</para>
    /// <para>GuildDiplomaticAnnouncementPacket</para>
    /// </summary>
    internal class x0281 : Package
    {
        #region public field

        #endregion

        #region public attribute

        public ushort Type => 0x0281;
        public ushort Size => 258;        
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

        public void Process(WorldSession session)
        {
            
        }
    }
}

