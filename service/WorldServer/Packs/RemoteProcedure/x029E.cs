#pragma warning disable CS8618

using TouchSocket.Core;
using WorldServer.Service;

namespace WorldServer.Packs.Protocol
{
    /// <summary>
    /// <para>计费系统错误</para>
    /// <para>计费系统错误</para>
    /// </summary>
    internal class x029E : Package
    {
        #region public field

        #endregion

        #region public attribute

        public ushort Type => 0x029E;
        public ushort Size => 134;        
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

