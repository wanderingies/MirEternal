#pragma warning disable CS8618

using TouchSocket.Core;
using WorldServer.Service;

namespace WorldServer.Packs.Protocol
{
    /// <summary>
    /// <para>UnknownS2</para>
    /// <para>UnknownS692</para>
    /// </summary>
    internal class x02B4 : Package
    {
        #region public field

        #endregion

        #region public attribute

        public ushort Type => 0x02B4;
        public ushort Size => 16;        
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

