#pragma warning disable CS8618

using TouchSocket.Core;
using GameServer.Service;

namespace GameServer.Packs.Protocols
{
    /// <summary>
    /// <para>InquireAboutSpecifiedProductPacket</para>
    /// <para>InquireAboutSpecifiedProductPacket</para>
    /// </summary>
    internal class x0268 : Package
    {
        #region public

        #endregion

        #region marshal


        #endregion

        #region attribute

        public ushort Type => 0x0268;
        public ushort Size => 6;
        public ushort rSize => 0;
        #endregion

        public x0268()
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

