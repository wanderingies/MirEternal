#pragma warning disable CS8618

using TouchSocket.Core;
using WorldServer.Service;

namespace WorldServer.Packs.Protocol
{
    /// <summary>
    /// <para>CharacterLearningSkillPacket</para>
    /// <para>CharacterLearningSkillPacket</para>
    /// </summary>
    internal class x0059 : Package
    {
        #region public field

		public Int32 角色编号;
		public UInt16 SkillId;
        #endregion

        #region public attribute

        public ushort Type => 0x0059;
        public ushort Size => 9;        
        #endregion
        
        #region private field


        #endregion

        public ByteBlock Marshal(ByteBlock byteBlock)
        {
			byteBlock.Write(角色编号);
			byteBlock.Write(SkillId);
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

