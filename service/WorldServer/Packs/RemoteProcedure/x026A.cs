#pragma warning disable CS8618

using TouchSocket.Core;
using WorldServer.Service;

namespace WorldServer.Packs.Protocol
{
    /// <summary>
    /// <para>AddWarehouseAnnouncementPacket</para>
    /// <para>AddWarehouseAnnouncementPacket</para>
    /// </summary>
    internal class x026A : Package
    {
        #region public field

        #endregion

        #region public attribute

        public ushort Type => 0x026A;
        public ushort Size => 107;        
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

