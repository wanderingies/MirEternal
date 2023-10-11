#pragma warning disable CS8618

using TouchSocket.Core;
using GameServer.Service;

namespace GameServer.Packs.Protocol
{
    /// <summary>
    /// <para>领取特权礼包</para>
    /// <para>领取特权礼包</para>
    /// </summary>
    internal class x00D8 : Package
    {
        #region public field

		public Byte 特权类型;
		public Byte 礼包位置;
        #endregion

        #region public attribute

        public ushort Type => 0x00D8;
        public ushort Size => 4;        
        #endregion
        
        #region private field


        #endregion

        public ByteBlock Marshal(ByteBlock byteBlock)
        {
            return byteBlock;
        }

        public ByteBlock UnMarshal(ByteBlock byteBlock)
        {
			特权类型 = byteBlock.ReadByte();
			礼包位置 = byteBlock.ReadByte();
            return byteBlock;
        }

        public void Process(GameSession session)
        {
            
        }
    }
}

