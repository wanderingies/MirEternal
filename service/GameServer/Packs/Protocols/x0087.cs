#pragma warning disable CS8618

using TouchSocket.Core;
using GameServer.Service;

namespace GameServer.Packs.Protocol
{
    /// <summary>
    /// <para>CreateNewFriendGroupPacket(已屏蔽)</para>
    /// <para>CreateNewFriendGroupPacket</para>
    /// </summary>
    internal class x0087 : Package
    {
        #region public field

        #endregion

        #region public attribute

        public ushort Type => 0x0087;
        public ushort Size => 28;        
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

