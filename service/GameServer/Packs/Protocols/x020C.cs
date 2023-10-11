#pragma warning disable CS8618

using TouchSocket.Core;
using GameServer.Service;

namespace GameServer.Packs.Protocol
{
    /// <summary>
    /// <para>MobileFriendsGroupPacket(已屏蔽)</para>
    /// <para>MobileFriendsGroupPacket</para>
    /// </summary>
    internal class x020C : Package
    {
        #region public field

        #endregion

        #region public attribute

        public ushort Type => 0x020C;
        public ushort Size => 7;        
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

