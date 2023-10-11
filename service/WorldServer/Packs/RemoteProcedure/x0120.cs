#pragma warning disable CS8618

using TouchSocket.Core;
using WorldServer.Service;

namespace WorldServer.Packs.Protocol
{
    /// <summary>
    /// <para>同步签到信息</para>
    /// <para>同步签到信息</para>
    /// </summary>
    internal class x0120 : Package
    {
        #region public field

		public Boolean 能否签到;
		public Byte 签到次数;
        #endregion

        #region public attribute

        public ushort Type => 0x0120;
        public ushort Size => 5;        
        #endregion
        
        #region private field


        #endregion

        public ByteBlock Marshal(ByteBlock byteBlock)
        {
			byteBlock.Write(能否签到);
			byteBlock.Write(签到次数);
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

