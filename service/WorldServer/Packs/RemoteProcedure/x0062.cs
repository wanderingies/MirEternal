#pragma warning disable CS8618

using TouchSocket.Core;
using WorldServer.Service;

namespace WorldServer.Packs.Protocol
{
    /// <summary>
    /// <para>技能释放中断</para>
    /// <para>技能释放中断</para>
    /// </summary>
    internal class x0062 : Package
    {
        #region public field

		public Int32 对象编号;
		public UInt16 SkillId;
		public Byte SkillLevel;
		public Byte 技能铭文;
		public Byte 动作编号;
		public Byte 技能分段;
        #endregion

        #region public attribute

        public ushort Type => 0x0062;
        public ushort Size => 13;        
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

