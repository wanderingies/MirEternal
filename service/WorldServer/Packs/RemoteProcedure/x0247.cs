#pragma warning disable CS8618

using TouchSocket.Core;
using WorldServer.Service;

namespace WorldServer.Packs.Protocol
{
    /// <summary>
    /// <para>创建行会应答</para>
    /// <para>创建行会应答</para>
    /// </summary>
    internal class x0247 : Package
    {
        #region public field

		public String GuildName;
        #endregion

        #region public attribute

        public ushort Type => 0x0247;
        public ushort Size => 48;        
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

