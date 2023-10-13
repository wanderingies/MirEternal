#pragma warning disable CS8618

using TouchSocket.Core;
using GameServer.Service;

namespace GameServer.Packs.Protocols
{
    /// <summary>
    /// <para>角色跑动</para>
    /// <para>物品描述</para>
    /// </summary>
    internal class x0011 : Package
    {
        #region public

        #endregion

        #region marshal

        public byte[] ItemInfo;
        #endregion

        #region attribute

        public ushort Type => 0x0011;
        public ushort Size => 6;
        public ushort rSize => 0;
        #endregion

        public x0011()
        {
            ItemInfo = new byte[] { 0 };
        }

        #region private


        #endregion

        public ByteBlock Marshal(ByteBlock byteBlock)
        {
            byteBlock.Write(ItemInfo);
            return byteBlock;
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

