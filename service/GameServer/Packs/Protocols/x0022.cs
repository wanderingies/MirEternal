#pragma warning disable CS8618

using TouchSocket.Core;
using GameServer.Service;

namespace GameServer.Packs.Protocol
{
    /// <summary>
    /// <para>释放技能</para>
    /// <para>CharacterReleaseSkillsPacket</para>
    /// </summary>
    internal class x0022 : Package
    {
        #region public

		public UInt16 SkillId;
		public Byte 动作编号;
		public Int32 目标编号;
		public UInt16 锚点高度;
        #endregion

        #region marshal


        #endregion

        #region attribute

        public ushort Type => 0x0022;
        public ushort Size => 16;     
        public ushort rSize => 0;
        #endregion
        
        public x0022() 
        {
        }

        #region private


        #endregion

        public ByteBlock Marshal(ByteBlock byteBlock)
        {
            throw new NotImplementedException();
        }

        public ByteBlock UnMarshal(ByteBlock byteBlock)
        {
			SkillId = byteBlock.ReadUInt16();
			动作编号 = byteBlock.ReadByte();
			目标编号 = byteBlock.ReadInt32();
			锚点高度 = byteBlock.ReadUInt16();
			return byteBlock;
        }

        public void Process(GameSession gameSession)
        {
            throw new NotImplementedException();
        }
    }
}

