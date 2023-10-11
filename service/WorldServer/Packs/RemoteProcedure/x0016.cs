#pragma warning disable CS8618

using TouchSocket.Core;
using WorldServer.Service;

namespace WorldServer.Packs.Protocol
{
    /// <summary>
    /// <para>SyncReputationListPacket(不同步会导致怪物不能ActiveAttack)</para>
    /// <para>SyncReputationListPacket</para>
    /// </summary>
    internal class x0016 : Package
    {
        #region public field

        #endregion

        #region public attribute

        public ushort Type => 0x0016;
        public ushort Size => 338;        
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

