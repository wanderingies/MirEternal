#pragma warning disable CS8618

using TouchSocket.Core;
using GameServer.Service;

namespace GameServer.Packs.Protocols
{
    /// <summary>
    /// <para>领取特权礼包</para>
    /// <para>领取特权礼包</para>
    /// </summary>
    internal class x00D8 : Package
    {
        #region public

        public byte 特权类型;
        public byte 礼包位置;
        #endregion

        #region marshal


        #endregion

        #region attribute

        public ushort Type => 0x00D8;
        public ushort Size => 4;
        public ushort rSize => 0;
        #endregion

        public x00D8()
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
            特权类型 = byteBlock.ReadByte();
            礼包位置 = byteBlock.ReadByte();
            return byteBlock;
        }

        public void Process(GameSession gameSession)
        {
            throw new NotImplementedException();
        }
    }
}

