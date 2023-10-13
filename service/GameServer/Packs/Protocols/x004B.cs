#pragma warning disable CS8618

using TouchSocket.Core;
using GameServer.Service;

namespace GameServer.Packs.Protocols
{
    /// <summary>
    /// <para>ToggleDoubleInscriptionBitPacket</para>
    /// <para>ToggleDoubleInscriptionBitPacket</para>
    /// </summary>
    internal class x004B : Package
    {
        #region public

        public byte 装备类型;
        public byte 装备位置;
        public byte 操作参数;
        #endregion

        #region marshal


        #endregion

        #region attribute

        public ushort Type => 0x004B;
        public ushort Size => 5;
        public ushort rSize => 0;
        #endregion

        public x004B()
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
            装备类型 = byteBlock.ReadByte();
            装备位置 = byteBlock.ReadByte();
            操作参数 = byteBlock.ReadByte();
            return byteBlock;
        }

        public void Process(GameSession gameSession)
        {
            throw new NotImplementedException();
        }
    }
}

