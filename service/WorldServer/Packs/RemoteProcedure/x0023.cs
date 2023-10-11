#pragma warning disable CS8618

using TouchSocket.Core;
using WorldServer.Service;

namespace WorldServer.Packs.Protocol
{
    /// <summary>
    /// <para>同步角色装备</para>
    /// <para>SyncPlayerEquipPacket</para>
    /// </summary>
    internal class x0023 : Package
    {
        #region public field

		public Int32 ObjectId;
		public Byte EquipmentItemCount;
        #endregion

        #region public attribute

        public ushort Type => 0x0023;
        public ushort Size => 0;        
        #endregion
        
        #region private field


        #endregion

        public ByteBlock Marshal(ByteBlock byteBlock)
        {
			byteBlock.Write(ObjectId);
			byteBlock.Write(EquipmentItemCount);
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

