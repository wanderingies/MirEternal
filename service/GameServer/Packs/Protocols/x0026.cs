#pragma warning disable CS8618

using TouchSocket.Core;
using GameServer.Service;

namespace GameServer.Packs.Protocols
{
    /// <summary>
    /// <para>ToggleAttackMode</para>
    /// <para>ToggleAttackMode</para>
    /// </summary>
    internal class x0026 : Package
    {
        #region public

        public byte AttackMode;
        #endregion

        #region marshal


        #endregion

        #region attribute

        public ushort Type => 0x0026;
        public ushort Size => 3;
        public ushort rSize => 0;
        #endregion

        public x0026()
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
            AttackMode = byteBlock.ReadByte();
            return byteBlock;
        }

        public void Process(GameSession gameSession)
        {
            throw new NotImplementedException();
        }
    }
}

