#pragma warning disable CS8618

using TouchSocket.Core;
using GameServer.Service;

namespace GameServer.Packs.Protocols
{
    /// <summary>
    /// <para>LockItemPacket</para>
    /// <para>LockItemPacket</para>
    /// </summary>
    internal class x0061 : Package
    {
        #region public

        public byte BackpackType;
        public byte Unknown;
        public byte Slot;
        #endregion

        #region marshal


        #endregion

        #region attribute

        public ushort Type => 0x0061;
        public ushort Size => 5;
        public ushort rSize => 0;
        #endregion

        public x0061()
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
            BackpackType = byteBlock.ReadByte();
            Unknown = byteBlock.ReadByte();
            Slot = byteBlock.ReadByte();
            return byteBlock;
        }

        public void Process(GameSession gameSession)
        {
            throw new NotImplementedException();
        }
    }
}

