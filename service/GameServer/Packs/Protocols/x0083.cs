#pragma warning disable CS8618

using TouchSocket.Core;
using GameServer.Service;

namespace GameServer.Packs.Protocol
{
    /// <summary>
    /// <para>SendChatMessagePacket(附近|广播|传音)</para>
    /// <para>SendChatMessagePacket</para>
    /// </summary>
    internal class x0083 : Package
    {
        #region public field

        #endregion

        #region public attribute

        public ushort Type => 0x0083;
        public ushort Size => 0;        
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

