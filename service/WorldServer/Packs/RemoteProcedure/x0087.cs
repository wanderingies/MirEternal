#pragma warning disable CS8618

using TouchSocket.Core;
using WorldServer.Service;

namespace WorldServer.Packs.Protocol
{
    /// <summary>
    /// <para>拾取物品</para>
    /// <para>PlayersPickupItemPacket</para>
    /// </summary>
    internal class x0087 : Package
    {
        #region public field

		public Int32 ObjectId;
		public byte[] ItemData;
        #endregion

        #region public attribute

        public ushort Type => 0x0087;
        public ushort Size => 0;        
        #endregion
        
        #region private field


        #endregion

        public ByteBlock Marshal(ByteBlock byteBlock)
        {
			byteBlock.Write(ObjectId);
			byteBlock.Write(ItemData);
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

