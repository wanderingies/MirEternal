#pragma warning disable CS8618

using TouchSocket.Core;
using WorldServer.Service;

namespace WorldServer.Packs.Protocol
{
    /// <summary>
    /// <para>触发技能扩展(技能信息,目标,反馈,耗时)</para>
    /// <para>触发技能扩展</para>
    /// </summary>
    internal class x005F : Package
    {
        #region public field

		public Int32 对象编号;
		public UInt16 SkillId;
		public Byte SkillLevel;
		public Byte 技能铭文;
		public Byte 动作编号;
		public Byte 技能分段;
		public Byte 未知参数;
		public byte[] 命中描述;
        #endregion

        #region public attribute

        public ushort Type => 0x005F;
        public ushort Size => 0;        
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
			byteBlock.Write(技能分段);
			byteBlock.Write(未知参数);
			byteBlock.Write(命中描述);
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

