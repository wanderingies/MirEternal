#pragma warning disable CS8618

using TouchSocket.Core;
using WorldServer.Service;

namespace WorldServer.Packs.Protocol
{
    /// <summary>
    /// <para>MartialArtsChallengeListPacket</para>
    /// <para>MartialArtsChallengeListPacket</para>
    /// </summary>
    internal class x02AA : Package
    {
        #region public field

        #endregion

        #region public attribute

        public ushort Type => 0x02AA;
        public ushort Size => 326;        
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

