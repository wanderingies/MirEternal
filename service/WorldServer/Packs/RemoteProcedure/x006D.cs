#pragma warning disable CS8618

using TouchSocket.Core;
using WorldServer.Service;

namespace WorldServer.Packs.Protocol
{
    /// <summary>
    /// <para>AddedSkillCooldownPacket</para>
    /// <para>AddedSkillCooldownPacket</para>
    /// </summary>
    internal class x006D : Package
    {
        #region public field

		public Int32 CoolingId;
		public Int32 Cooldown;
        #endregion

        #region public attribute

        public ushort Type => 0x006D;
        public ushort Size => 10;        
        #endregion
        
        #region private field


        #endregion

        public ByteBlock Marshal(ByteBlock byteBlock)
        {
			byteBlock.Write(CoolingId);
			byteBlock.Write(Cooldown);
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

