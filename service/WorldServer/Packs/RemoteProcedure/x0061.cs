#pragma warning disable CS8618

using TouchSocket.Core;
using WorldServer.Service;

namespace WorldServer.Packs.Protocol
{
    /// <summary>
    /// <para>触发命中特效(技能信息,目标,血量,反馈)</para>
    /// <para>触发命中特效</para>
    /// </summary>
    internal class x0061 : Package
    {
        #region public field

		public Int32 对象编号;
		public UInt16 SkillId;
		public Byte SkillLevel;
		public Byte 技能铭文;
		public Byte 动作编号;
		public Int32 目标编号;
		public Int32 技能伤害;
		public UInt16 招架伤害;
		public UInt16 技能反馈;
        #endregion

        #region public attribute

        public ushort Type => 0x0061;
        public ushort Size => 28;        
        #endregion
        
        #region private field


        #endregion

        public ByteBlock Marshal(ByteBlock byteBlock)
        {
			byteBlock.Write(对象编号);
			byteBlock.Write(SkillId);
			byteBlock.Write(SkillLevel);
			byteBlock.Write(技能铭文);
			byteBlock.Write(动作编号);
			byteBlock.Write(目标编号);
			byteBlock.Write(技能伤害);
			byteBlock.Write(招架伤害);
			byteBlock.Write(技能反馈);
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

