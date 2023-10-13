#pragma warning disable CS8618

using TouchSocket.Core;
using GameServer.Service;

namespace GameServer.Packs.Protocols
{
    /// <summary>
    /// <para>ToggleAwekeningExpPacket</para>
    /// <para>ToggleAwakeningExpPacket</para>
    /// </summary>
    internal class x00E1 : Package
    {
        #region public

        public bool Enabled;
        #endregion

        #region marshal


        #endregion

        #region attribute

        public ushort Type => 0x00E1;
        public ushort Size => 3;
        public ushort rSize => 0;
        #endregion

        public x00E1()
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
            Enabled = byteBlock.ReadBoolean();
            return byteBlock;
        }

        public void Process(GameSession gameSession)
        {
            throw new NotImplementedException();
        }
    }
}

