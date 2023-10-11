#pragma warning disable CS8618

using TouchSocket.Core;
using WorldServer.Service;

namespace WorldServer.Packs.Protocol
{
    /// <summary>
    /// <para>SyncSkillCountPacket</para>
    /// <para>SyncSkillCountPacket</para>
    /// </summary>
    internal class x015D : Package
    {
        #region public field

		public UInt16 SkillId;
		public Byte SkillCount;
		public Int32 技能冷却;
        #endregion

        #region public attribute

        public ushort Type => 0x015D;
        public ushort Size => 14;        
        #endregion
        
        #region private field


        #endregion

        public ByteBlock Marshal(ByteBlock byteBlock)
        {
			byteBlock.Write(SkillId);
			byteBlock.Write(SkillCount);
			byteBlock.Write(技能冷却);
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

