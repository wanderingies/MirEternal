#pragma warning disable CS8618

using TouchSocket.Core;
using GameServer.Service;

namespace GameServer.Packs.Protocol
{
    /// <summary>
    /// <para>更改行会公告</para>
    /// <para>更改行会公告</para>
    /// </summary>
    internal class x0232 : Package
    {
        #region public field

        #endregion

        #region public attribute

        public ushort Type => 0x0232;
        public ushort Size => 0;        
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

