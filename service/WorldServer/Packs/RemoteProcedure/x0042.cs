#pragma warning disable CS8618

using TouchSocket.Core;
using WorldServer.Service;

namespace WorldServer.Packs.Protocol
{
    /// <summary>
    /// <para>同步Npcc数据扩展(宠物)</para>
    /// <para>SyncExtendedDataPacket</para>
    /// </summary>
    internal class x0042 : Package
    {
        #region public field

		public Int32 对象编号;
		public UInt16 MobId;
		public Byte 对象质量;
		public Byte 对象等级;
		public Int32 MaxHP;
		public Byte 对象类型;
		public Byte CurrentRank;
		public Int32 主人编号;
		public String 主人名字;
        #endregion

        #region public attribute

        public ushort Type => 0x0042;
        public ushort Size => 58;        
        #endregion
        
        #region private field


        #endregion

        public ByteBlock Marshal(ByteBlock byteBlock)
        {
			byteBlock.Write(对象编号);
			byteBlock.Write(MobId);
			byteBlock.Write(对象质量);
			byteBlock.Write(对象等级);
			byteBlock.Write(MaxHP);
			byteBlock.Write(对象类型);
			byteBlock.Write(CurrentRank);
			byteBlock.Write(主人编号);
			byteBlock.Write(主人名字);
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

