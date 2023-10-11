#pragma warning disable CS8618

using TouchSocket.Core;
using WorldServer.Service;

namespace WorldServer.Packs.Protocol
{
    /// <summary>
    /// <para>AnnouncementDissolutionGuildPacket</para>
    /// <para>AnnouncementDissolutionGuildPacket</para>
    /// </summary>
    internal class x0254 : Package
    {
        #region public field

        #endregion

        #region public attribute

        public ushort Type => 0x0254;
        public ushort Size => 2;        
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

