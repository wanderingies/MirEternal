#pragma warning disable CS8618

using TouchSocket.Core;
using GameServer.Service;

namespace GameServer.Packs.Protocols
{
    /// <summary>
    /// <para>CharacterOrganizerBackpackPacket</para>
    /// <para>CharacterOrganizerBackpackPacket</para>
    /// </summary>
    internal class x003A : Package
    {
        #region public

        public byte 背包类型;
        #endregion

        #region marshal


        #endregion

        #region attribute

        public ushort Type => 0x003A;
        public ushort Size => 3;
        public ushort rSize => 0;
        #endregion

        public x003A()
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
            背包类型 = byteBlock.ReadByte();
            return byteBlock;
        }

        public void Process(GameSession gameSession)
        {
            throw new NotImplementedException();
        }
    }
}

