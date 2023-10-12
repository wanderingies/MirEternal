#pragma warning disable CS8618

using TouchSocket.Core;
using WorldServer.Service;

namespace WorldServer.Packs.Protocol
{
    /// <summary>
    /// <para>触发技能正常(技能信息,目标,反馈,耗时)</para>
    /// <para>SkillHitNormal</para>
    /// </summary>
    internal class x0060 : Package
    {
        #region public field

		public Int32 ObjectId;
		public UInt16 SkillId;
		public Byte SkillLevel;
		public Byte SkillInscription;
		public Byte ActionId;
		public Byte SkillSegment;
		public byte[] HitDescription;
        #endregion

        #region public attribute

        public ushort Type => 0x0060;
        public ushort Size => 0;        
        #endregion
        
        #region private field


        #endregion

        public ByteBlock Marshal(ByteBlock byteBlock)
        {
			byteBlock.Write(ObjectId);
			byteBlock.Write(SkillId);
			byteBlock.Write(SkillLevel);
			byteBlock.Write(SkillInscription);
			byteBlock.Write(ActionId);
			byteBlock.Write(SkillSegment);
			byteBlock.Write(HitDescription);
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

