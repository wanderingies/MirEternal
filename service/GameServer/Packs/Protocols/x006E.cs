#pragma warning disable CS8618

using TouchSocket.Core;
using GameServer.Service;

namespace GameServer.Packs.Protocol
{
    /// <summary>
    /// <para>更改摊位外观</para>
    /// <para>更改摊位外观</para>
    /// </summary>
    internal class x006E : Package
    {
        #region public field

		public Byte 外观编号;
        #endregion

        #region public attribute

        public ushort Type => 0x006E;
        public ushort Size => 3;        
        #endregion
        
        #region private field


        #endregion

        public ByteBlock Marshal(ByteBlock byteBlock)
        {
            return byteBlock;
        }

        public ByteBlock UnMarshal(ByteBlock byteBlock)
        {
			外观编号 = byteBlock.ReadByte();
            return byteBlock;
        }

        public void Process(GameSession session)
        {
            
        }
    }
}

