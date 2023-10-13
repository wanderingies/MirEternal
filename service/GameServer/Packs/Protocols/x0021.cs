#pragma warning disable CS8618

using TouchSocket.Core;
using GameServer.Service;

namespace GameServer.Packs.Protocols
{
    /// <summary>
    /// <para>CharacterSwitchSkillsPacket</para>
    /// <para>CharacterSwitchSkillsPacket</para>
    /// </summary>
    internal class x0021 : Package
    {
        #region public

        public ushort SkillId;
        #endregion

        #region marshal

        public int roleid;
        #endregion

        #region attribute

        public ushort Type => 0x0021;
        public ushort Size => 4;
        public ushort rSize => 6;
        #endregion

        public x0021()
        {
        }

        #region private


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

        public void Process(GameSession gameSession)
        {
            throw new NotImplementedException();
        }
    }
}

