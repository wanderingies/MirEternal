#pragma warning disable CS8618

using TouchSocket.Core;
using GameServer.Service;

namespace GameServer.Packs.Protocol
{
    /// <summary>
    /// <para>不知道干嘛的</para>
    /// <para>ReservedPacketZeroThreePacket</para>
    /// </summary>
    internal class x00FB : Package
    {
        #region public field

        #endregion

        #region public attribute

        public ushort Type => 0x00FB;
        public ushort Size => 3;        
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

