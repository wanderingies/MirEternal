#pragma warning disable CS8618

using TouchSocket.Core;
using GameServer.Service;

namespace GameServer.Packs.Protocol
{
    /// <summary>
    /// <para>传承武器铭文</para>
    /// <para>传承武器铭文</para>
    /// </summary>
    internal class x0047 : Package
    {
        #region public field

		public Byte 来源类型;
		public Byte 来源位置;
		public Byte 目标类型;
		public Byte 目标位置;
        #endregion

        #region public attribute

        public ushort Type => 0x0047;
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
			来源类型 = byteBlock.ReadByte();
			来源位置 = byteBlock.ReadByte();
			目标类型 = byteBlock.ReadByte();
			目标位置 = byteBlock.ReadByte();
            return byteBlock;
        }

        public void Process(GameSession session)
        {
            
        }
    }
}

