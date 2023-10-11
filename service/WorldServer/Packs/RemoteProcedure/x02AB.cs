#pragma warning disable CS8618

using TouchSocket.Core;
using WorldServer.Service;

namespace WorldServer.Packs.Protocol
{
    /// <summary>
    /// <para>YanwuArenaChallengeListPacket</para>
    /// <para>YanwuArenaChallengeListPacket</para>
    /// </summary>
    internal class x02AB : Package
    {
        #region public field

        #endregion

        #region public attribute

        public ushort Type => 0x02AB;
        public ushort Size => 558;        
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

