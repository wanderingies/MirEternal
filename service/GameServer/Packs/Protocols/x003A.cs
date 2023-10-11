#pragma warning disable CS8618

using TouchSocket.Core;
using GameServer.Service;

namespace GameServer.Packs.Protocol
{
    /// <summary>
    /// <para>CharacterOrganizerBackpackPacket</para>
    /// <para>CharacterOrganizerBackpackPacket</para>
    /// </summary>
    internal class x003A : Package
    {
        #region public field

		public Byte 背包类型;
        #endregion

        #region public attribute

        public ushort Type => 0x003A;
        public ushort Size => 3;        
        #endregion
        
        #region private field


        #endregion

        public ByteBlock Marshal(ByteBlock byteBlock)
        {
            return byteBlock;
        }

        public ByteBlock UnMarshal(ByteBlock byteBlock)
        {
			背包类型 = byteBlock.ReadByte();
            return byteBlock;
        }

        public void Process(GameSession session)
        {
            
        }
    }
}

