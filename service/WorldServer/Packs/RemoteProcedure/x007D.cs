#pragma warning disable CS8618

using TouchSocket.Core;
using WorldServer.Service;

namespace WorldServer.Packs.Protocol
{
    /// <summary>
    /// <para>技能升级</para>
    /// <para>玩家技能升级</para>
    /// </summary>
    internal class x007D : Package
    {
        #region public field

		public UInt16 SkillId;
		public Byte SkillLevel;
        #endregion

        #region public attribute

        public ushort Type => 0x007D;
        public ushort Size => 5;        
        #endregion
        
        #region private field


        #endregion

        public ByteBlock Marshal(ByteBlock byteBlock)
        {
			byteBlock.Write(SkillId);
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

