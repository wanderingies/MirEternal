#pragma warning disable CS8618

using TouchSocket.Core;
using WorldServer.Service;

namespace WorldServer.Packs.Protocol
{
    /// <summary>
    /// <para>升级建筑公告</para>
    /// <para>升级建筑公告</para>
    /// </summary>
    internal class x0272 : Package
    {
        #region public field

        #endregion

        #region public attribute

        public ushort Type => 0x0272;
        public ushort Size => 15;        
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

