#pragma warning disable CS8618

using TouchSocket.Core;
using WorldServer.Service;

namespace WorldServer.Packs.Protocol
{
    /// <summary>
    /// <para>SyncTeacherInfoPacket</para>
    /// <para>SyncTeacherInfoPacket</para>
    /// </summary>
    internal class x0019 : Package
    {
        #region public field

		public Int32 限制时间;
		public Byte 师门参数;
		public Byte 师门推送;
        #endregion

        #region public attribute

        public ushort Type => 0x0019;
        public ushort Size => 8;        
        #endregion
        
        #region private field


        #endregion

        public ByteBlock Marshal(ByteBlock byteBlock)
        {
			byteBlock.Write(限制时间);
			byteBlock.Write(师门参数);
			byteBlock.Write(师门推送);
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

