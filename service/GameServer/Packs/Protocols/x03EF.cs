#pragma warning disable CS8618

using TouchSocket.Core;
using GameServer.Service;

namespace GameServer.Packs.Protocols
{
    /// <summary>
    /// <para>测试网关网速</para>
    /// <para>TestNetworkSpeedPacket</para>
    /// </summary>
    internal class x03EF : Package
    {
        #region public

        public int ClientTime;
        #endregion

        #region marshal


        #endregion

        #region attribute

        public ushort Type => 0x03EF;
        public ushort Size => 6;
        public ushort rSize => 0;
        #endregion

        public x03EF()
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
            ClientTime = byteBlock.ReadInt32();
            return byteBlock;
        }

        public void Process(GameSession gameSession)
        {
            throw new NotImplementedException();
        }
    }
}

