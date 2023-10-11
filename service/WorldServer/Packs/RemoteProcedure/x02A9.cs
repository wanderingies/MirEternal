#pragma warning disable CS8618

using TouchSocket.Core;
using WorldServer.Service;

namespace WorldServer.Packs.Protocol
{
    /// <summary>
    /// <para>InfoPerfomanceObjectsPacket</para>
    /// <para>InfoPerfomanceObjectsPacket</para>
    /// </summary>
    internal class x02A9 : Package
    {
        #region public field

        #endregion

        #region public attribute

        public ushort Type => 0x02A9;
        public ushort Size => 38;        
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

