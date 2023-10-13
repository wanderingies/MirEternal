#pragma warning disable CS8618

using TouchSocket.Core;
using GameServer.Service;

namespace GameServer.Packs.Protocols
{
    /// <summary>
    /// <para>查询排名榜单</para>
    /// <para>查询排名榜单</para>
    /// </summary>
    internal class x025C : Package
    {
        #region public

        public int 榜单类型;
        public int 起始位置;
        #endregion

        #region marshal


        #endregion

        #region attribute

        public ushort Type => 0x025C;
        public ushort Size => 10;
        public ushort rSize => 0;
        #endregion

        public x025C()
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
            榜单类型 = byteBlock.ReadInt32();
            起始位置 = byteBlock.ReadInt32();
            return byteBlock;
        }

        public void Process(GameSession gameSession)
        {
            throw new NotImplementedException();
        }
    }
}

