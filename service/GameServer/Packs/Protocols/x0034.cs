#pragma warning disable CS8618

using TouchSocket.Core;
using GameServer.Service;

namespace GameServer.Packs.Protocol
{
    /// <summary>
    /// <para>CharacterRepurchageItemsPacket</para>
    /// <para>CharacterRepurchageItemsPacket</para>
    /// </summary>
    internal class x0034 : Package
    {
        #region public field

		public Byte 物品位置;
        #endregion

        #region public attribute

        public ushort Type => 0x0034;
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
			物品位置 = byteBlock.ReadByte();
            return byteBlock;
        }

        public void Process(GameSession session)
        {
            
        }
    }
}

