#pragma warning disable CS8618

using TouchSocket.Core;
using WorldServer.Service;

namespace WorldServer.Packs.Protocol
{
    /// <summary>
    /// <para>SyncPlayerData</para>
    /// <para>SyncPlayerData</para>
    /// </summary>
    internal class x0043 : Package
    {
        #region public field

        #endregion

        #region public attribute

        public ushort Type => 0x0043;
        public ushort Size => 93;        
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

