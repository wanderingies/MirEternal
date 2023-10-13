#pragma warning disable CS8618

using TouchSocket.Core;
using GameServer.Service;

namespace GameServer.Packs.Protocols
{
    /// <summary>
    /// <para>查看行会列表</para>
    /// <para>查看行会列表</para>
    /// </summary>
    internal class x0229 : Package
    {
        #region public

        public byte 查看方式;
        public int 行会编号;
        #endregion

        #region marshal


        #endregion

        #region attribute

        public ushort Type => 0x0229;
        public ushort Size => 7;
        public ushort rSize => 0;
        #endregion

        public x0229()
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
            查看方式 = byteBlock.ReadByte();
            行会编号 = byteBlock.ReadInt32();
            return byteBlock;
        }

        public void Process(GameSession gameSession)
        {
            throw new NotImplementedException();
        }
    }
}

