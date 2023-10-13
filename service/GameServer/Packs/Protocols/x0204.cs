#pragma warning disable CS8618

using TouchSocket.Core;
using GameServer.Service;

namespace GameServer.Packs.Protocols
{
    /// <summary>
    /// <para>SendTeamRequestPacket</para>
    /// <para>SendTeamRequestPacket</para>
    /// </summary>
    internal class x0204 : Package
    {
        #region public

        public int 对象编号;
        #endregion

        #region marshal


        #endregion

        #region attribute

        public ushort Type => 0x0204;
        public ushort Size => 6;
        public ushort rSize => 0;
        #endregion

        public x0204()
        {
        }

        #region private


        #endregion

        public ByteBlock Marshal(ByteBlock byteBlock)
        {
            throw new NotImplementedException();
        }

        public ByteBlock UnMarshal(ByteBlock byteBlock)
        {
            对象编号 = byteBlock.ReadInt32();
            return byteBlock;
        }

        public void Process(GameSession gameSession)
        {
            throw new NotImplementedException();
        }
    }
}

