#pragma warning disable CS8618

using TouchSocket.Core;
using WorldServer.Service;

namespace WorldServer.Packs.Protocol
{
    /// <summary>
    /// <para>加入行会公告</para>
    /// <para>加入行会公告</para>
    /// </summary>
    internal class x026E : Package
    {
        #region public field

		public String GuildName;
        #endregion

        #region public attribute

        public ushort Type => 0x026E;
        public ushort Size => 27;        
        #endregion
        
        #region private field


        #endregion

        public ByteBlock Marshal(ByteBlock byteBlock)
        {
			byteBlock.Write(GuildName);
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

