#pragma warning disable CS8618

using TouchSocket.Core;
using GameServer.Service;

namespace GameServer.Packs.Protocol
{
    /// <summary>
    /// <para>QueryGuildAchievementsPacket</para>
    /// <para>QueryGuildAchievementsPacket</para>
    /// </summary>
    internal class x0244 : Package
    {
        #region public field

        #endregion

        #region public attribute

        public ushort Type => 0x0244;
        public ushort Size => 2;        
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

