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
        #region public

		public UInt16 Field;
		public Byte Unknown;
        #endregion

        #region marshal


        #endregion

        #region attribute

        public ushort Type => 0x00DB;
        public ushort Size => 5;     
        public ushort rSize => 0;
        #endregion
        
        public x00DB() 
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
			Field = byteBlock.ReadUInt16();
			Unknown = byteBlock.ReadByte();
			return byteBlock;
        }

        public void Process(GameSession gameSession)
        {
            throw new NotImplementedException();
        }
    }
}

