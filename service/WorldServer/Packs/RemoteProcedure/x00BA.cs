#pragma warning disable CS8618

using TouchSocket.Core;
using WorldServer.Service;

namespace WorldServer.Packs.Protocol
{
    /// <summary>
    /// <para>SyncClientVariablesPacket(物品快捷键)</para>
    /// <para>SyncClientVariablesPacket</para>
    /// </summary>
    internal class x00BA : Package
    {
        #region public field

        #endregion

        #region public attribute

        public ushort Type => 0x00BA;
        public ushort Size => 514;        
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

