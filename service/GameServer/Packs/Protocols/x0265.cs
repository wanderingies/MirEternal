#pragma warning disable CS8618

using TouchSocket.Core;
using GameServer.Service;

namespace GameServer.Packs.Protocol
{
    /// <summary>
    /// <para>购买玛法特权</para>
    /// <para>购买玛法特权</para>
    /// </summary>
    internal class x0265 : Package
    {
        #region public field

		public Byte 特权类型;
		public Byte 购买数量;
        #endregion

        #region public attribute

        public ushort Type => 0x0265;
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
			购买数量 = byteBlock.ReadByte();
            return byteBlock;
        }

        public void Process(GameSession session)
        {
            
        }
    }
}

