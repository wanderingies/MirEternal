#pragma warning disable CS8618

using TouchSocket.Core;
using GameServer.Service;

namespace GameServer.Packs.Protocols
{
    /// <summary>
    /// <para>玩家解锁交易</para>
    /// <para>玩家解锁交易</para>
    /// </summary>
    internal class x0099 : Package
    {
        #region public

        #endregion

        #region marshal


        #endregion

        #region attribute

        public ushort Type => 0x0099;
        public ushort Size => 2;
        public ushort rSize => 0;
        #endregion

        public x0099()
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
            throw new NotImplementedException();
        }

        public void Process(GameSession gameSession)
        {
            throw new NotImplementedException();
        }
    }
}

