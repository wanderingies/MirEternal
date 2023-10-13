#pragma warning disable CS8618

using TouchSocket.Core;
using GameServer.Service;

namespace GameServer.Packs.Protocols
{
    /// <summary>
    /// <para>UnknownC1</para>
    /// <para>UnknownC642</para>
    /// </summary>
    internal class x0282 : Package
    {
        #region public

        #endregion

        #region marshal


        #endregion

        #region attribute

        public ushort Type => 0x0282;
        public ushort Size => 4;
        public ushort rSize => 0;
        #endregion

        public x0282()
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
            return byteBlock;
        }

        public void Process(GameSession gameSession)
        {
            Program.service.Logger.Warning("0x0282 => The method or operation is not implemented.");
        }
    }
}

