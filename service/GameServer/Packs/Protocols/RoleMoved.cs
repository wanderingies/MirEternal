#pragma warning disable CS8618

using TouchSocket.Core;
using GameServer.Service;

namespace GameServer.Packs.Protocol
{
    /// <summary>
    /// 角色走动
    /// </summary>
    internal class RoleMoved : Package
    {
        #region public field

        public byte[] SkillInfo;
        #endregion

        #region public attribute

        public ushort Type => 0x0012;
        public ushort Size => 6;        
        #endregion
        
        #region private field


        #endregion

        public RoleMoved()
        {
            SkillInfo = new byte[] { 0 };
        }

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

