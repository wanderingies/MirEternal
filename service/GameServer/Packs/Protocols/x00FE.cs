#pragma warning disable CS8618

using TouchSocket.Core;
using GameServer.Service;

namespace GameServer.Packs.Protocols
{
    /// <summary>
    /// <para>购买每周特惠</para>
    /// <para>购买每周特惠</para>
    /// </summary>
    internal class x00FE : Package
    {
        #region public

        public int 礼包编号;
        #endregion

        #region marshal


        #endregion

        #region attribute

        public ushort Type => 0x00FE;
        public ushort Size => 6;
        public ushort rSize => 0;
        #endregion

        public x00FE()
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
            礼包编号 = byteBlock.ReadInt32();
            return byteBlock;
        }

        public void Process(GameSession gameSession)
        {
            throw new NotImplementedException();
        }
    }
}

