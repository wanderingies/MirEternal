#pragma warning disable CS8618

using TouchSocket.Core;
using GameServer.Service;

namespace GameServer.Packs.Protocols
{
    /// <summary>
    /// <para>更改收徒推送</para>
    /// <para>更改收徒推送</para>
    /// </summary>
    internal class x009E : Package
    {
        #region public

        public bool 收徒推送;
        #endregion

        #region marshal


        #endregion

        #region attribute

        public ushort Type => 0x009E;
        public ushort Size => 3;
        public ushort rSize => 0;
        #endregion

        public x009E()
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
            收徒推送 = byteBlock.ReadBoolean();
            return byteBlock;
        }

        public void Process(GameSession gameSession)
        {
            throw new NotImplementedException();
        }
    }
}

