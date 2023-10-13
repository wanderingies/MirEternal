#pragma warning disable CS8618

using TouchSocket.Core;
using GameServer.Service;

namespace GameServer.Packs.Protocols
{
    /// <summary>
    /// <para>同意收徒申请</para>
    /// <para>同意收徒申请</para>
    /// </summary>
    internal class x021B : Package
    {
        #region public

        public int 对象编号;
        #endregion

        #region marshal


        #endregion

        #region attribute

        public ushort Type => 0x021B;
        public ushort Size => 6;
        public ushort rSize => 0;
        #endregion

        public x021B()
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
            对象编号 = byteBlock.ReadInt32();
            return byteBlock;
        }

        public void Process(GameSession gameSession)
        {
            throw new NotImplementedException();
        }
    }
}

