#pragma warning disable CS8618

using TouchSocket.Core;
using GameServer.Service;

namespace GameServer.Packs.Protocol
{
    /// <summary>
    /// <para>InviteToJoinGuildPacket</para>
    /// <para>InviteToJoinGuildPacket</para>
    /// </summary>
    internal class x022F : Package
    {
        #region public field

		public String 对象名字;
        #endregion

        #region public attribute

        public ushort Type => 0x022F;
        public ushort Size => 34;        
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

