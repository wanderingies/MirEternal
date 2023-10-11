#pragma warning disable CS8618

using TouchSocket.Core;
using WorldServer.Service;

namespace WorldServer.Packs.Protocol
{
    /// <summary>
    /// <para>CharacterRemoveSkillPacket</para>
    /// <para>CharacterRemoveSkillPacket</para>
    /// </summary>
    internal class x005A : Package
    {
        #region public field

		public UInt16 SkillId;
        #endregion

        #region public attribute

        public ushort Type => 0x005A;
        public ushort Size => 4;        
        #endregion
        
        #region private field


        #endregion

        public ByteBlock Marshal(ByteBlock byteBlock)
        {
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

