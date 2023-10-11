#pragma warning disable CS8618

using TouchSocket.Core;
using WorldServer.Service;

namespace WorldServer.Packs.Protocol
{
    /// <summary>
    /// <para>查询通缉详情</para>
    /// <para>查询通缉详情</para>
    /// </summary>
    internal class x0139 : Package
    {
        #region public field

        #endregion

        #region public attribute

        public ushort Type => 0x0139;
        public ushort Size => 35;        
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

