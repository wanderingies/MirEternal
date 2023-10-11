#pragma warning disable CS8618

using TouchSocket.Core;
using WorldServer.Service;

namespace WorldServer.Packs.Protocol
{
    /// <summary>
    /// <para>SyncMasterRewardPacket(师徒通用)</para>
    /// <para>SyncMasterRewardPacket</para>
    /// </summary>
    internal class x0057 : Package
    {
        #region public field

        #endregion

        #region public attribute

        public ushort Type => 0x0057;
        public ushort Size => 94;        
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

