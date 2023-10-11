#pragma warning disable CS8618

using TouchSocket.Core;
using WorldServer.Service;

namespace WorldServer.Packs.Protocol
{
    /// <summary>
    /// <para>SyncSkillExpPacket</para>
    /// <para>SyncSkillExpPacket</para>
    /// </summary>
    internal class x007E : Package
    {
        #region public field

		public UInt16 SkillId;
		public UInt16 CurrentExp;
        #endregion

        #region public attribute

        public ushort Type => 0x007E;
        public ushort Size => 6;        
        #endregion
        
        #region private field


        #endregion

        public ByteBlock Marshal(ByteBlock byteBlock)
        {
			byteBlock.Write(SkillId);
			byteBlock.Write(CurrentExp);
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

