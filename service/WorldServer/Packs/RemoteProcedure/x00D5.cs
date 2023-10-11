#pragma warning disable CS8618

using TouchSocket.Core;
using WorldServer.Service;

namespace WorldServer.Packs.Protocol
{
    /// <summary>
    /// <para>玩家获得称号</para>
    /// <para>ObtainTitlePacket</para>
    /// </summary>
    internal class x00D5 : Package
    {
        #region public field

		public Byte Id;
		public Int32 ExpireTime;
        #endregion

        #region public attribute

        public ushort Type => 0x00D5;
        public ushort Size => 7;        
        #endregion
        
        #region private field


        #endregion

        public ByteBlock Marshal(ByteBlock byteBlock)
        {
			byteBlock.Write(Id);
			byteBlock.Write(ExpireTime);
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

