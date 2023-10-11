#pragma warning disable CS8618

using TouchSocket.Core;
using GameServer.Service;

namespace GameServer.Packs.Protocol
{
    /// <summary>
    /// <para>不知道干嘛的, 离开进入安全区触发</para>
    /// <para>ReservedPacketZeroOnePacket</para>
    /// </summary>
    internal class x0020 : Package
    {
        #region public field

        #endregion

        #region public attribute

        public ushort Type => 0x0020;
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

        public void Process(GameSession session)
        {
            
        }
    }
}

