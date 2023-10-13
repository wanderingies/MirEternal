#pragma warning disable CS8618

using TouchSocket.Core;
using GameServer.Service;

namespace GameServer.Packs.Protocols
{
    /// <summary>
    /// <para>更改摊位名字</para>
    /// <para>更改摊位名字</para>
    /// </summary>
    internal class x006D : Package
    {
        #region public

        public string 摊位名字;
        #endregion

        #region marshal


        #endregion

        #region attribute

        public ushort Type => 0x006D;
        public ushort Size => 35;
        public ushort rSize => 0;
        #endregion

        public x006D()
        {
        }

        #region private


        #endregion

        public ByteBlock Marshal(ByteBlock byteBlock)
        {
            throw new NotImplementedException();
        }

        public ByteBlock UnMarshal(ByteBlock byteBlock)
        {
            throw new NotImplementedException();
        }

        public void Process(GameSession gameSession)
        {
            throw new NotImplementedException();
        }
    }
}

