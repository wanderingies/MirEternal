#pragma warning disable CS8618

using TouchSocket.Core;
using WorldServer.Service;

namespace WorldServer.Packs.Protocol
{
    /// <summary>
    /// <para>释放完成, 可以释放下一个技能</para>
    /// <para>技能释放完成</para>
    /// </summary>
    internal class x0063 : Package
    {
        #region public field

		public UInt16 SkillId;
		public Byte 动作编号;
        #endregion

        #region public attribute

        public ushort Type => 0x0063;
        public ushort Size => 5;        
        #endregion
        
        #region private field


        #endregion

        public ByteBlock Marshal(ByteBlock byteBlock)
        {
			byteBlock.Write(SkillId);
			byteBlock.Write(动作编号);
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

