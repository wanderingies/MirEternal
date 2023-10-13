#pragma warning disable CS8618

using TouchSocket.Core;
using GameServer.Service;

namespace GameServer.Packs.Protocols
{
    /// <summary>
    /// <para>变更会员职位</para>
    /// <para>变更会员职位</para>
    /// </summary>
    internal class x0235 : Package
    {
        #region public

        public int 对象编号;
        public byte 对象职位;
        #endregion

        #region marshal


        #endregion

        #region attribute

        public ushort Type => 0x0235;
        public ushort Size => 7;
        public ushort rSize => 0;
        #endregion

        public x0235()
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
            对象职位 = byteBlock.ReadByte();
            return byteBlock;
        }

        public void Process(GameSession gameSession)
        {
            throw new NotImplementedException();
        }
    }
}

