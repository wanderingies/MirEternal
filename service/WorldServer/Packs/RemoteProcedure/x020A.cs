#pragma warning disable CS8618

using TouchSocket.Core;
using WorldServer.Service;

namespace WorldServer.Packs.Protocol
{
    /// <summary>
    /// <para>同步队员信息</para>
    /// <para>同步队员信息</para>
    /// </summary>
    internal class x020A : Package
    {
        #region public field

		public Int32 队伍编号;
		public Int32 对象编号;
		public Int32 对象等级;
		public Int32 MaxHP;
		public Int32 MaxMP;
		public Int32 CurrentHP;
		public Int32 CurrentMP;
		public Int32 CurrentMap;
		public Int32 当前线路;
		public Int32 横向坐标;
		public Int32 纵向坐标;
		public Int32 坐标高度;
		public Byte AttackMode;
        #endregion

        #region public attribute

        public ushort Type => 0x020A;
        public ushort Size => 51;        
        #endregion
        
        #region private field


        #endregion

        public ByteBlock Marshal(ByteBlock byteBlock)
        {
			byteBlock.Write(队伍编号);
			byteBlock.Write(对象编号);
			byteBlock.Write(对象等级);
			byteBlock.Write(MaxHP);
			byteBlock.Write(MaxMP);
			byteBlock.Write(CurrentHP);
			byteBlock.Write(CurrentMP);
			byteBlock.Write(CurrentMap);
			byteBlock.Write(当前线路);
			byteBlock.Write(横向坐标);
			byteBlock.Write(纵向坐标);
			byteBlock.Write(坐标高度);
			byteBlock.Write(AttackMode);
            return byteBlock;
        }

        public ByteBlock UnMarshal(ByteBlock byteBlock)
        {
            return byteBlock;
        }

        public void Process(WorldSession session)
        {
            
        }
    }
}

