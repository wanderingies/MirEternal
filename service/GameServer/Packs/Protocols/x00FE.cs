#pragma warning disable CS8618

using TouchSocket.Core;
using GameServer.Service;

namespace GameServer.Packs.Protocol
{
    /// <summary>
    /// <para>购买每周特惠</para>
    /// <para>购买每周特惠</para>
    /// </summary>
    internal class x00FE : Package
    {
        #region public field

		public Int32 礼包编号;
        #endregion

        #region public attribute

        public ushort Type => 0x00FE;
        public ushort Size => 6;        
        #endregion
        
        #region private field


        #endregion

        public ByteBlock Marshal(ByteBlock byteBlock)
        {
            return byteBlock;
        }

        public ByteBlock UnMarshal(ByteBlock byteBlock)
        {
			礼包编号 = byteBlock.ReadInt32();
            return byteBlock;
        }

        public void Process(GameSession session)
        {
            
        }
    }
}

