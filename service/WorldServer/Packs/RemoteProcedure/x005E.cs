#pragma warning disable CS8618

using TouchSocket.Core;
using WorldServer.Service;

namespace WorldServer.Packs.Protocol
{
    /// <summary>
    /// <para>StartToReleaseSkillPacket</para>
    /// <para>StartToReleaseSkillPacket</para>
    /// </summary>
    internal class x005E : Package
    {
        #region public field

		public Int32 ObjectId;
		public UInt16 SkillId;
		public Byte SkillLevel;
		public Byte SkillInscription;
		public Int32 TargetId;
		public UInt16 AnchorHeight;
		public UInt16 AccelerationRate1;
		public UInt16 AccelerationRate2;
		public Byte ActionId;
        #endregion

        #region public attribute

        public ushort Type => 0x005E;
        public ushort Size => 25;        
        #endregion
        
        #region private field


        #endregion

        public ByteBlock Marshal(ByteBlock byteBlock)
        {
			byteBlock.Write(ObjectId);
			byteBlock.Write(SkillId);
			byteBlock.Write(SkillLevel);
			byteBlock.Write(SkillInscription);
			byteBlock.Write(TargetId);
			byteBlock.Write(AnchorHeight);
			byteBlock.Write(AccelerationRate1);
			byteBlock.Write(AccelerationRate2);
			byteBlock.Write(ActionId);
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

