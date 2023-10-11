#pragma warning disable CS8618

using TouchSocket.Core;
using WorldServer.Service;

namespace WorldServer.Packs.Protocol
{
    /// <summary>
    /// <para>跨服武道排名</para>
    /// <para>SyncMartialArtsRankingPacket</para>
    /// </summary>
    internal class x02AF : Package
    {
        #region public field

        #endregion

        #region public attribute

        public ushort Type => 0x02AF;
        public ushort Size => 499;        
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

