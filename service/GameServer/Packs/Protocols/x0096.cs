#pragma warning disable CS8618

using TouchSocket.Core;
using GameServer.Service;

namespace GameServer.Packs.Protocols
{
    /// <summary>
    /// <para>玩家放入物品</para>
    /// <para>玩家放入物品</para>
    /// </summary>
    internal class x0096 : Package
    {
        #region public

        public byte 放入位置;
        public byte 放入物品;
        public byte 物品容器;
        public byte 物品位置;
        #endregion

        #region marshal


        #endregion

        #region attribute

        public ushort Type => 0x0096;
        public ushort Size => 6;
        public ushort rSize => 0;
        #endregion

        public x0096()
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
            放入位置 = byteBlock.ReadByte();
            放入物品 = byteBlock.ReadByte();
            物品容器 = byteBlock.ReadByte();
            物品位置 = byteBlock.ReadByte();
            return byteBlock;
        }

        public void Process(GameSession gameSession)
        {
            throw new NotImplementedException();
        }
    }
}

