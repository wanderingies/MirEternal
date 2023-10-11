#pragma warning disable CS8618

using TouchSocket.Core;
using WorldServer.Service;

namespace WorldServer.Packs.Protocol
{
    /// <summary>
    /// <para>CharacterAssemblyInscriptionPacket</para>
    /// <para>CharacterAssemblyInscriptionPacket</para>
    /// </summary>
    internal class x0065 : Package
    {
        #region public field

		public UInt16 SkillId;
		public Byte Id;
		public Byte SkillLevel;
        #endregion

        #region public attribute

        public ushort Type => 0x0065;
        public ushort Size => 6;        
        #endregion
        
        #region private field


        #endregion

        public ByteBlock Marshal(ByteBlock byteBlock)
        {
			byteBlock.Write(SkillId);
			byteBlock.Write(Id);
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

