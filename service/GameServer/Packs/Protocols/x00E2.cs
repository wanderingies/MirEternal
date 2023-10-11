#pragma warning disable CS8618

using TouchSocket.Core;
using GameServer.Service;

namespace GameServer.Packs.Protocol
{
    /// <summary>
    /// <para>UpgradeAwakeningSkillPacket</para>
    /// <para>UpgradeAwakeningSkillPacket</para>
    /// </summary>
    internal class x00E2 : Package
    {
        #region public field

		public UInt16 SkillId;
        #endregion

        #region public attribute

        public ushort Type => 0x00E2;
        public ushort Size => 4;        
        #endregion
        
        #region private field


        #endregion

        public ByteBlock Marshal(ByteBlock byteBlock)
        {
            return byteBlock;
        }

        public ByteBlock UnMarshal(ByteBlock byteBlock)
        {
			SkillId = byteBlock.ReadUInt16();
            return byteBlock;
        }

        public void Process(GameSession session)
        {
            
        }
    }
}

