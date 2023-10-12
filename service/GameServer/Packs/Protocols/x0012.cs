#pragma warning disable CS8618

using TouchSocket.Core;
using GameServer.Service;

namespace GameServer.Packs.Protocol
{
    /// <summary>
    /// client    => 角色走动
    /// <para>server    => 技能信息</para>
    /// </summary>
    internal class x0012 : Package
    {
        #region public field

        public byte[] SkillInfo;
        #endregion

        #region public attribute

        public ushort Type => 0x0012;
        public ushort Size => 6;
        public ushort rSize => 0;
        #endregion

        public x0012()
        {
            SkillInfo = new byte[] { 0 };
        }
        
        #region private field


        #endregion

        public ByteBlock Marshal(ByteBlock byteBlock)
        {
            byteBlock.Write(SkillInfo);
            return byteBlock;
        }

        public ByteBlock UnMarshal(ByteBlock byteBlock)
        {
            return byteBlock;
        }

        public void Process(GameSession session)
        {
            
        }
    }
}

