#pragma warning disable CS8618

using TouchSocket.Core;
using GameServer.Service;

namespace GameServer.Packs.Protocol
{
    /// <summary>
    /// <para>装备技能</para>
    /// <para>CharacterEquipmentSkillsPacket</para>
    /// </summary>
    internal class x0027 : Package
    {
        #region public field

		public Byte 技能栏位;
		public UInt16 SkillId;
        #endregion

        #region public attribute

        public ushort Type => 0x0027;
        public ushort Size => 5;        
        #endregion
        
        #region private field


        #endregion

        public ByteBlock Marshal(ByteBlock byteBlock)
        {
            return byteBlock;
        }

        public ByteBlock UnMarshal(ByteBlock byteBlock)
        {
			技能栏位 = byteBlock.ReadByte();
			SkillId = byteBlock.ReadUInt16();
            return byteBlock;
        }

        public void Process(GameSession session)
        {
            
        }
    }
}

