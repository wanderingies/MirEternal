#pragma warning disable CS8618

using TouchSocket.Core;
using WorldServer.Service;

namespace WorldServer.Packs.Protocol
{
    /// <summary>
    /// <para>查询排行榜单</para>
    /// <para>查询排行榜单</para>
    /// </summary>
    internal class x0295 : Package
    {
        #region public field

        #endregion

        #region public attribute

        public ushort Type => 0x0295;
        public ushort Size => 191;        
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

