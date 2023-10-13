#pragma warning disable CS8618

using TouchSocket.Core;
using GameServer.Service;

namespace GameServer.Packs.Protocols
{
    /// <summary>
    /// <para>玩家镶嵌灵石</para>
    /// <para>玩家镶嵌灵石</para>
    /// </summary>
    internal class x0044 : Package
    {
        #region public

        public byte 装备类型;
        public byte 装备位置;
        public byte 装备孔位;
        public byte 灵石类型;
        public byte 灵石位置;
        #endregion

        #region marshal


        #endregion

        #region attribute

        public ushort Type => 0x0044;
        public ushort Size => 7;
        public ushort rSize => 0;
        #endregion

        public x0044()
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
            装备类型 = byteBlock.ReadByte();
            装备位置 = byteBlock.ReadByte();
            装备孔位 = byteBlock.ReadByte();
            灵石类型 = byteBlock.ReadByte();
            灵石位置 = byteBlock.ReadByte();
            return byteBlock;
        }

        public void Process(GameSession gameSession)
        {
            throw new NotImplementedException();
        }
    }
}

