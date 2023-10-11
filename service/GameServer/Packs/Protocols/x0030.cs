#pragma warning disable CS8618

using TouchSocket.Core;
using GameServer.Service;

namespace GameServer.Packs.Protocol
{
    /// <summary>
    /// <para>CharacterPickupItemsPacket</para>
    /// <para>CharacterPickupItemsPacket</para>
    /// </summary>
    internal class x0030 : Package
    {
        #region public field

		public Int32 Id;
        #endregion

        #region public attribute

        public ushort Type => 0x0030;
        public ushort Size => 7;        
        #endregion
        
        #region private field


        #endregion

        public ByteBlock Marshal(ByteBlock byteBlock)
        {
            return byteBlock;
        }

        public ByteBlock UnMarshal(ByteBlock byteBlock)
        {
			Id = byteBlock.ReadInt32();
            return byteBlock;
        }

        public void Process(GameSession session)
        {
            
        }
    }
}

