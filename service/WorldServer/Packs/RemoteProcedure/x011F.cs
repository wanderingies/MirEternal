#pragma warning disable CS8618

using TouchSocket.Core;
using WorldServer.Service;

namespace WorldServer.Packs.Protocol
{
    /// <summary>
    /// <para>查询问卷调查</para>
    /// <para>问卷调查应答</para>
    /// </summary>
    internal class x011F : Package
    {
        #region public field

        #endregion

        #region public attribute

        public ushort Type => 0x011F;
        public ushort Size => 1282;        
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

