#pragma warning disable CS8618

using TouchSocket.Core;
using GameServer.Service;

namespace GameServer.Packs.Protocols
{
    /// <summary>
    /// <para>GetCurrentMountPacket</para>
    /// <para>GetCurrentMountPacket</para>
    /// </summary>
    internal class x00DA : Package
    {
        #region public

        public byte SelectedMountId;
        #endregion

        #region marshal


        #endregion

        #region attribute

        public ushort Type => 0x00DA;
        public ushort Size => 3;
        public ushort rSize => 0;
        #endregion

        public x00DA()
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
            SelectedMountId = byteBlock.ReadByte();
            return byteBlock;
        }

        public void Process(GameSession gameSession)
        {
            throw new NotImplementedException();
        }
    }
}

