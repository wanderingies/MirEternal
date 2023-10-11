#pragma warning disable CS8618

using TouchSocket.Core;
using WorldServer.Service;

namespace WorldServer.Packs.Protocol
{
    /// <summary>
    /// <para>查询邮件内容</para>
    /// <para>同步邮件内容</para>
    /// </summary>
    internal class x023F : Package
    {
        #region public field

        #endregion

        #region public attribute

        public ushort Type => 0x023F;
        public ushort Size => 674;        
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

