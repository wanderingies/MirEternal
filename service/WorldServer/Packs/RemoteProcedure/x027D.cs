#pragma warning disable CS8618

using TouchSocket.Core;
using WorldServer.Service;

namespace WorldServer.Packs.Protocol
{
    /// <summary>
    /// <para>GuildWarProclamationPacket</para>
    /// <para>GuildWarProclamationPacket</para>
    /// </summary>
    internal class x027D : Package
    {
        #region public field

        #endregion

        #region public attribute

        public ushort Type => 0x027D;
        public ushort Size => 7;        
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

