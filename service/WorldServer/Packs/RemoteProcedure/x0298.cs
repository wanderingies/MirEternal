#pragma warning disable CS8618

using TouchSocket.Core;
using WorldServer.Service;

namespace WorldServer.Packs.Protocol
{
    /// <summary>
    /// <para>BuildLordStatuePacket</para>
    /// <para>BuildLordStatuePacket</para>
    /// </summary>
    internal class x0298 : Package
    {
        #region public field

        #endregion

        #region public attribute

        public ushort Type => 0x0298;
        public ushort Size => 226;        
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

