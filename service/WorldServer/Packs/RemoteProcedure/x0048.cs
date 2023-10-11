#pragma warning disable CS8618

using TouchSocket.Core;
using WorldServer.Service;

namespace WorldServer.Packs.Protocol
{
    /// <summary>
    /// <para>SyncPetLevelPacket</para>
    /// <para>SyncPetLevelPacket</para>
    /// </summary>
    internal class x0048 : Package
    {
        #region public field

		public Int32 宠物编号;
		public Byte 宠物等级;
        #endregion

        #region public attribute

        public ushort Type => 0x0048;
        public ushort Size => 7;        
        #endregion
        
        #region private field


        #endregion

        public ByteBlock Marshal(ByteBlock byteBlock)
        {
			byteBlock.Write(宠物编号);
			byteBlock.Write(宠物等级);
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

