#pragma warning disable CS8618

using TouchSocket.Core;
using GameServer.Service;

namespace GameServer.Packs.Protocols
{
    /// <summary>
    /// <para>RequestTreasureDataPacket</para>
    /// <para>RequestTreasureDataPacket</para>
    /// </summary>
    internal class x0257 : Package
    {
        #region public

        public int 数据版本;
        #endregion

        #region marshal


        #endregion

        #region attribute

        public ushort Type => 0x0257;
        public ushort Size => 6;
        public ushort rSize => 0;
        #endregion

        public x0257()
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
            数据版本 = byteBlock.ReadInt32();
            return byteBlock;
        }

        public void Process(GameSession gameSession)
        {
            throw new NotImplementedException();
        }
    }
}

