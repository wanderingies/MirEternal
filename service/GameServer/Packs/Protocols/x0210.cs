#pragma warning disable CS8618

using TouchSocket.Core;
using GameServer.Service;

namespace GameServer.Packs.Protocols
{
    /// <summary>
    /// <para>删除仇人</para>
    /// <para>玩家删除仇人</para>
    /// </summary>
    internal class x0210 : Package
    {
        #region public

        public int 对象编号;
        #endregion

        #region marshal


        #endregion

        #region attribute

        public ushort Type => 0x0210;
        public ushort Size => 6;
        public ushort rSize => 0;
        #endregion

        public x0210()
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

