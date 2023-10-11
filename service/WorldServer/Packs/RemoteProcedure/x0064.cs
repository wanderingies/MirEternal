#pragma warning disable CS8618

using TouchSocket.Core;
using WorldServer.Service;

namespace WorldServer.Packs.Protocol
{
    /// <summary>
    /// <para>CharacterDragSkillsPacket</para>
    /// <para>CharacterDragSkillsPacket</para>
    /// </summary>
    internal class x0064 : Package
    {
        #region public field

		public Byte 技能栏位;
		public UInt16 SkillId;
		public Byte Id;
		public Byte SkillLevel;
        #endregion

        #region public attribute

        public ushort Type => 0x0064;
        public ushort Size => 7;        
        #endregion
        
        #region private field


        #endregion

        public ByteBlock Marshal(ByteBlock byteBlock)
        {
			byteBlock.Write(技能栏位);
			byteBlock.Write(SkillId);
			byteBlock.Write(Id);
			byteBlock.Write(SkillLevel);
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

