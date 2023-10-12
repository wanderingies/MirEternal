#pragma warning disable CS8618

using TouchSocket.Core;
using WorldServer.Service;

namespace WorldServer.Packs.Protocol
{
    /// <summary>
    /// <para>SelectTargetDetailsPacket</para>
    /// <para>SelectTargetDetailsPacket</para>
    /// </summary>
    internal class x007A : Package
    {
        #region public field

		public Int32 对象编号;
		public Int32 CurrentHP;
		public Int32 CurrentMP;
		public Int32 MaxHP;
		public Int32 MaxMP;
		public byte[] Buff描述;
        #endregion

        #region public attribute

        public ushort Type => 0x007A;
        public ushort Size => 0;        
        #endregion
        
        #region private field


        #endregion

        public ByteBlock Marshal(ByteBlock byteBlock)
        {
			byteBlock.Write(对象编号);
			byteBlock.Write(CurrentHP);
			byteBlock.Write(CurrentMP);
			byteBlock.Write(MaxHP);
			byteBlock.Write(MaxMP);
			byteBlock.Write(Buff描述);
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

