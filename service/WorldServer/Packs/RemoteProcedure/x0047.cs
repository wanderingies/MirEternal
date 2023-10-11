#pragma warning disable CS8618

using TouchSocket.Core;
using WorldServer.Service;

namespace WorldServer.Packs.Protocol
{
    /// <summary>
    /// <para>同步对象Buff</para>
    /// <para>同步对象Buff</para>
    /// </summary>
    internal class x0047 : Package
    {
        #region public field

        #endregion

        #region public attribute

        public ushort Type => 0x0047;
        public ushort Size => 36;        
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

