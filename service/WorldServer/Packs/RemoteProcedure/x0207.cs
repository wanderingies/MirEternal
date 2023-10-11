#pragma warning disable CS8618

using TouchSocket.Core;
using WorldServer.Service;

namespace WorldServer.Packs.Protocol
{
    /// <summary>
    /// <para>TeamMembersLeavePacket</para>
    /// <para>TeamMembersLeavePacket</para>
    /// </summary>
    internal class x0207 : Package
    {
        #region public field

		public Int32 队伍编号;
		public Int32 对象编号;
        #endregion

        #region public attribute

        public ushort Type => 0x0207;
        public ushort Size => 10;        
        #endregion
        
        #region private field


        #endregion

        public ByteBlock Marshal(ByteBlock byteBlock)
        {
			byteBlock.Write(队伍编号);
			byteBlock.Write(对象编号);
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

