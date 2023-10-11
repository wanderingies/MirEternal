#pragma warning disable CS8618

using TouchSocket.Core;
using WorldServer.Service;

namespace WorldServer.Packs.Protocol
{
    /// <summary>
    /// <para>ReceiveChatMessagesPacket(system/private chat/broadcast/voice/guild/team)</para>
    /// <para>ReceiveChatMessagesPacket</para>
    /// </summary>
    internal class x021C : Package
    {
        #region public field

        #endregion

        #region public attribute

        public ushort Type => 0x021C;
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

        public void Process(WorldSession session)
        {
            
        }
    }
}

