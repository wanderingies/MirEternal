#pragma warning disable CS8618

using TouchSocket.Core;
using GameServer.Service;

namespace GameServer.Packs.Protocol
{
    /// <summary>
    /// <para>AddMountSkillPacket</para>
    /// <para>AddMountSkillPacket</para>
    /// </summary>
    internal class x00DB : Package
    {
        #region public field

		public UInt16 Field;
		public Byte Unknown;
        #endregion

        #region public attribute

        public ushort Type => 0x00DB;
        public ushort Size => 5;        
        #endregion
        
        #region private field


        #endregion

        public ByteBlock Marshal(ByteBlock byteBlock)
        {
            return byteBlock;
        }

        public ByteBlock UnMarshal(ByteBlock byteBlock)
        {
			Field = byteBlock.ReadUInt16();
			Unknown = byteBlock.ReadByte();
            return byteBlock;
        }

        public void Process(GameSession session)
        {
            
        }
    }
}

