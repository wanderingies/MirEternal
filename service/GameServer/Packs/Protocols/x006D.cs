#pragma warning disable CS8618

using TouchSocket.Core;
using GameServer.Service;

namespace GameServer.Packs.Protocol
{
    /// <summary>
    /// <para>更改摊位名字</para>
    /// <para>更改摊位名字</para>
    /// </summary>
    internal class x006D : Package
    {
        #region public field

		public String 摊位名字;
        #endregion

        #region public attribute

        public ushort Type => 0x006D;
        public ushort Size => 35;        
        #endregion
        
        #region private field


        #endregion

        public ByteBlock Marshal(ByteBlock byteBlock)
        {
            return byteBlock;
        }

        public ByteBlock UnMarshal(ByteBlock byteBlock)
        {
            return byteBlock;
        }

        public void Process(GameSession session)
        {
            
        }
    }
}

