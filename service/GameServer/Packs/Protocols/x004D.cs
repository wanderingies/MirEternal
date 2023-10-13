#pragma warning disable CS8618

using TouchSocket.Core;
using GameServer.Service;

namespace GameServer.Packs.Protocols
{
    /// <summary>
    /// <para>ReplaceLowLevelInscriptionsPacket</para>
    /// <para>ReplaceLowLevelInscriptionsPacket</para>
    /// </summary>
    internal class x004D : Package
    {
        #region public

        public byte 装备类型;
        public byte 装备位置;
        #endregion

        #region marshal

        public byte StatId;
        public int Value;
        #endregion

        #region attribute

        public ushort Type => 0x004D;
        public ushort Size => 4;
        public ushort rSize => 7;
        #endregion

        public x004D()
        {
        }

        #region private


        #endregion

        public ByteBlock Marshal(ByteBlock byteBlock)
        {
            byteBlock.Write(StatId);
            byteBlock.Write(Value);
            return byteBlock;
        }

        public ByteBlock UnMarshal(ByteBlock byteBlock)
        {
            装备类型 = byteBlock.ReadByte();
            装备位置 = byteBlock.ReadByte();
            return byteBlock;
        }

        public void Process(GameSession gameSession)
        {
            throw new NotImplementedException();
        }
    }
}

