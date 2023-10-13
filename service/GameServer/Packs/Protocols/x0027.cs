#pragma warning disable CS8618

using TouchSocket.Core;
using GameServer.Service;

namespace GameServer.Packs.Protocols
{
    /// <summary>
    /// <para>装备技能</para>
    /// <para>CharacterEquipmentSkillsPacket</para>
    /// </summary>
    internal class x0027 : Package
    {
        #region public

        public byte 技能栏位;
        public ushort SkillId;
        #endregion

        #region marshal


        #endregion

        #region attribute

        public ushort Type => 0x0027;
        public ushort Size => 5;
        public ushort rSize => 0;
        #endregion

        public x0027()
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
            技能栏位 = byteBlock.ReadByte();
            SkillId = byteBlock.ReadUInt16();
            return byteBlock;
        }

        public void Process(GameSession gameSession)
        {
            throw new NotImplementedException();
        }
    }
}

