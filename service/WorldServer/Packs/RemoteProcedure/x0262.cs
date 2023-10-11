#pragma warning disable CS8618

using TouchSocket.Core;
using WorldServer.Service;

namespace WorldServer.Packs.Protocol
{
    /// <summary>
    /// <para>SendGuildNoticePacket</para>
    /// <para>SendGuildNoticePacket</para>
    /// </summary>
    internal class x0262 : Package
    {
        #region public field

		public Byte 提醒类型;
        #endregion

        #region public attribute

        public ushort Type => 0x0262;
        public ushort Size => 3;        
        #endregion
        
        #region private field


        #endregion

        public ByteBlock Marshal(ByteBlock byteBlock)
        {
			byteBlock.Write(提醒类型);
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

