#pragma warning disable CS8618

using TouchSocket.Core;
using GameServer.Service;

namespace GameServer.Packs.Protocols
{
    /// <summary>
    /// <para>UnknownC252</para>
    /// <para>UnknownC252</para>
    /// </summary>
    internal class x00FC : Package
    {
        #region public

        public int U1;
        #endregion

        #region marshal


        #endregion

        #region attribute

        public ushort Type => 0x00FC;
        public ushort Size => 0;
        public ushort rSize => 0;
        #endregion

        public x00FC()
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
            U1 = byteBlock.ReadInt32();
            return byteBlock;
        }

        public void Process(GameSession gameSession)
        {
            throw new NotImplementedException();
        }
    }
}

