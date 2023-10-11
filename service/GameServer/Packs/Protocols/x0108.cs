#pragma warning disable CS8618

using TouchSocket.Core;
using GameServer.Service;

namespace GameServer.Packs.Protocol
{
    /// <summary>
    /// <para>UnknownC4</para>
    /// <para>UnknownC264</para>
    /// </summary>
    internal class x0108 : Package
    {
        #region public field

        #endregion

        #region public attribute

        public ushort Type => 0x0108;
        public ushort Size => 22;        
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

        public void Process(GameSession session)
        {
            
        }
    }
}

