#pragma warning disable CS8618

using TouchSocket.Core;
using WorldServer.Service;

namespace WorldServer.Packs.Protocol
{
    /// <summary>
    /// <para>查询GuildName</para>
    /// <para>GuildNameAnswerPAcket</para>
    /// </summary>
    internal class x0246 : Package
    {
        #region public field

		public Int32 行会编号;
		public String GuildName;
		public Int32 会长编号;
		public Byte 行会人数;
		public Byte 行会等级;
        #endregion

        #region public attribute

        public ushort Type => 0x0246;
        public ushort Size => 48;        
        #endregion
        
        #region private field


        #endregion

        public ByteBlock Marshal(ByteBlock byteBlock)
        {
			byteBlock.Write(行会编号);
			byteBlock.Write(GuildName);
			byteBlock.Write(会长编号);
			byteBlock.Write(行会人数);
			byteBlock.Write(行会等级);
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

