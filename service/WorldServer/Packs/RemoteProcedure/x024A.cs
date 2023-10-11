#pragma warning disable CS8618

using TouchSocket.Core;
using WorldServer.Service;

namespace WorldServer.Packs.Protocol
{
    /// <summary>
    /// <para>FindGuildAnswersPacket</para>
    /// <para>FindGuildAnswersPacket</para>
    /// </summary>
    internal class x024A : Package
    {
        #region public field

        #endregion

        #region public attribute

        public ushort Type => 0x024A;
        public ushort Size => 231;        
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

