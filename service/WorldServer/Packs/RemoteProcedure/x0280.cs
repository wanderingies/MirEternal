#pragma warning disable CS8618

using TouchSocket.Core;
using WorldServer.Service;

namespace WorldServer.Packs.Protocol
{
    /// <summary>
    /// <para>DisarmHostileListPacket</para>
    /// <para>DisarmHostileListPacket</para>
    /// </summary>
    internal class x0280 : Package
    {
        #region public field

		public Int32 申请类型;
		public Int32 行会编号;
        #endregion

        #region public attribute

        public ushort Type => 0x0280;
        public ushort Size => 10;        
        #endregion
        
        #region private field


        #endregion

        public ByteBlock Marshal(ByteBlock byteBlock)
        {
			byteBlock.Write(申请类型);
			byteBlock.Write(行会编号);
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

