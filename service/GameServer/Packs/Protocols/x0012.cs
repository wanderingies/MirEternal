#pragma warning disable CS8618

using TouchSocket.Core;
using GameServer.Service;

namespace GameServer.Packs.Protocols
{
    /// <summary>
    /// <para>角色走动</para>
    /// <para>技能描述</para>
    /// </summary>
    internal class x0012 : Package
    {
        #region public

        #endregion

        #region marshal

        public byte[] SkillInfo;
        #endregion

        #region attribute

        public ushort Type => 0x0012;
        public ushort Size => 6;
        public ushort rSize => 0;
        #endregion

        public x0012()
        {
            SkillInfo = new byte[] { 0 };
        }

        #region private


        #endregion

        public ByteBlock Marshal(ByteBlock byteBlock)
        {
            byteBlock.Write(SkillInfo);
            return byteBlock;
        }

        public ByteBlock UnMarshal(ByteBlock byteBlock)
        {
            throw new NotImplementedException();
        }

        public void Process(GameSession gameSession)
        {
            throw new NotImplementedException();
        }
    }
}

