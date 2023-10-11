#pragma warning disable CS8618

using TouchSocket.Core;
using GameServer.Service;

namespace GameServer.Packs.Protocol
{
    /// <summary>
    /// <para>PublishWantedListPacket</para>
    /// <para>PublishWantedListPacket</para>
    /// </summary>
    internal class x00D3 : Package
    {
        #region public field

        #endregion

        #region public attribute

        public ushort Type => 0x00D3;
        public ushort Size => 50;        
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

