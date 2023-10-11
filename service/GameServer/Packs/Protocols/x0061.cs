#pragma warning disable CS8618

using TouchSocket.Core;
using GameServer.Service;

namespace GameServer.Packs.Protocol
{
    /// <summary>
    /// <para>LockItemPacket</para>
    /// <para>LockItemPacket</para>
    /// </summary>
    internal class x0061 : Package
    {
        #region public field

		public Byte BackpackType;
		public Byte Unknown;
		public Byte Slot;
        #endregion

        #region public attribute

        public ushort Type => 0x0061;
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
			BackpackType = byteBlock.ReadByte();
			Unknown = byteBlock.ReadByte();
			Slot = byteBlock.ReadByte();
            return byteBlock;
        }

        public void Process(GameSession session)
        {
            
        }
    }
}

