#pragma warning disable CS8618

using TouchSocket.Core;
using WorldServer.Service;

namespace WorldServer.Packs.Protocol
{
    /// <summary>
    /// <para>攻城获胜公告</para>
    /// <para>攻城获胜公告</para>
    /// </summary>
    internal class x0299 : Package
    {
        #region public field

        #endregion

        #region public attribute

        public ushort Type => 0x0299;
        public ushort Size => 226;        
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

