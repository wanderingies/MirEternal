#pragma warning disable CS8618

using TouchSocket.Core;
using GameServer.Service;

namespace GameServer.Packs.Protocol
{
    /// <summary>
    /// <para>CharacterSwitchSkillsPacket</para>
    /// <para>CharacterSwitchSkillsPacket</para>
    /// </summary>
    internal class x0021 : Package
    {
        #region public field

		public UInt16 SkillId;

        public int roleid;
        #endregion

        #region public attribute

        public ushort Type => 0x0021;
        public ushort Size => 4;        
        #endregion
        
        #region private field


        #endregion

        public ByteBlock Marshal(ByteBlock byteBlock)
        {
            byteBlock.Write(roleid);
            return byteBlock;
        }

        public ByteBlock UnMarshal(ByteBlock byteBlock)
        {
			SkillId = byteBlock.ReadUInt16();
            return byteBlock;
        }

        public void Process(GameSession session)
        {
            
        }
    }
}

