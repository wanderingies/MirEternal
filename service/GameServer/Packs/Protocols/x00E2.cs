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
        #region public

		public UInt16 SkillId;
        #endregion

        #region marshal


        #endregion

        #region attribute

        public ushort Type => 0x00E2;
        public ushort Size => 4;     
        public ushort rSize => 0;
        #endregion
        
        public x00E2() 
        {
        }

        #region private


        #endregion

        public ByteBlock Marshal(ByteBlock byteBlock)
        {
            throw new NotImplementedException();
        }

        public ByteBlock UnMarshal(ByteBlock byteBlock)
        {
			SkillId = byteBlock.ReadUInt16();
			return byteBlock;
        }

        public void Process(GameSession gameSession)
        {
            throw new NotImplementedException();
        }
    }
}

