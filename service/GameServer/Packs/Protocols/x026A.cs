#pragma warning disable CS8618

using TouchSocket.Core;
using GameServer.Service;

namespace GameServer.Packs.Protocol
{
    /// <summary>
    /// <para>上架平台商品</para>
    /// <para>上架平台商品</para>
    /// </summary>
    internal class x026A : Package
    {
        #region public field

        #endregion

        #region public attribute

        public ushort Type => 0x026A;
        public ushort Size => 9;        
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

