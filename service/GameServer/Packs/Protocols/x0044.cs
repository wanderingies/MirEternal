#pragma warning disable CS8618

using TouchSocket.Core;
using GameServer.Service;

namespace GameServer.Packs.Protocol
{
    /// <summary>
    /// <para>玩家镶嵌灵石</para>
    /// <para>玩家镶嵌灵石</para>
    /// </summary>
    internal class x0044 : Package
    {
        #region public field

		public Byte 装备类型;
		public Byte 装备位置;
		public Byte 装备孔位;
		public Byte 灵石类型;
		public Byte 灵石位置;
        #endregion

        #region public attribute

        public ushort Type => 0x0044;
        public ushort Size => 7;        
        #endregion
        
        #region private field


        #endregion

        public ByteBlock Marshal(ByteBlock byteBlock)
        {
            return byteBlock;
        }

        public ByteBlock UnMarshal(ByteBlock byteBlock)
        {
			装备类型 = byteBlock.ReadByte();
			装备位置 = byteBlock.ReadByte();
			装备孔位 = byteBlock.ReadByte();
			灵石类型 = byteBlock.ReadByte();
			灵石位置 = byteBlock.ReadByte();
            return byteBlock;
        }

        public void Process(GameSession session)
        {
            
        }
    }
}

