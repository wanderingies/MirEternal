#pragma warning disable CS8618

using TouchSocket.Core;
using WorldServer.Service;

namespace WorldServer.Packs.Protocol
{
    /// <summary>
    /// <para>SyncSkillLevelPacket数据</para>
    /// <para>SyncSkillLevelPacket</para>
    /// </summary>
    internal class x007F : Package
    {
        #region public field

		public UInt16 SkillId;
		public UInt16 CurrentExp;
		public Byte CurrentRank;
        #endregion

        #region public attribute

        public ushort Type => 0x007F;
        public ushort Size => 7;        
        #endregion
        
        #region private field


        #endregion

        public ByteBlock Marshal(ByteBlock byteBlock)
        {
			byteBlock.Write(SkillId);
			byteBlock.Write(CurrentExp);
			byteBlock.Write(CurrentRank);
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

