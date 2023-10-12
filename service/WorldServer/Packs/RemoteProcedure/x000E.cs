#pragma warning disable CS8618

using TouchSocket.Core;
using WorldServer.Service;

namespace WorldServer.Packs.Protocol
{
    /// <summary>
    /// <para>同步角色Stat</para>
    /// <para>同步角色Stat</para>
    /// </summary>
    internal class x000E : Package
    {
        #region public field

		public byte[] StatDescription;
        #endregion

        #region public attribute

        public ushort Type => 0x000E;
        public ushort Size => 0;        
        #endregion
        
        #region private field


        #endregion

        public ByteBlock Marshal(ByteBlock byteBlock)
        {
			byteBlock.Write(StatDescription);
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

