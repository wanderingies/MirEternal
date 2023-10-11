#pragma warning disable CS8618

using TouchSocket.Core;
using WorldServer.Service;

namespace WorldServer.Packs.Protocol
{
    /// <summary>
    /// <para>查询拜师名册应答</para>
    /// <para>SyncApprenticeshipRosterPacketAnswer</para>
    /// </summary>
    internal class x0221 : Package
    {
        #region public field

        #endregion

        #region public attribute

        public ushort Type => 0x0221;
        public ushort Size => 0;        
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

