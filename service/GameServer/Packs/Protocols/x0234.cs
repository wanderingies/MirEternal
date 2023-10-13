#pragma warning disable CS8618

using TouchSocket.Core;
using GameServer.Service;

namespace GameServer.Packs.Protocols
{
    /// <summary>
    /// <para>设置行会禁言</para>
    /// <para>设置行会禁言</para>
    /// </summary>
    internal class x0234 : Package
    {
        #region public

        public byte 禁言状态;
        public int 对象编号;
        #endregion

        #region marshal


        #endregion

        #region attribute

        public ushort Type => 0x0234;
        public ushort Size => 7;
        public ushort rSize => 0;
        #endregion

        public x0234()
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
            禁言状态 = byteBlock.ReadByte();
            对象编号 = byteBlock.ReadInt32();
            return byteBlock;
        }

        public void Process(GameSession gameSession)
        {
            throw new NotImplementedException();
        }
    }
}

