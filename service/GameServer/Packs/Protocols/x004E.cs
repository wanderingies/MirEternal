#pragma warning disable CS8618

using TouchSocket.Core;
using GameServer.Service;

namespace GameServer.Packs.Protocols
{
    /// <summary>
    /// <para>AbandonInscriptionReplacementPacket</para>
    /// <para>AbandonInscriptionReplacementPacket</para>
    /// </summary>
    internal class x004E : Package
    {
        #region public

        public byte 装备类型;
        public byte 装备位置;
        public int Id;
        #endregion

        #region marshal


        #endregion

        #region attribute

        public ushort Type => 0x004E;
        public ushort Size => 11;
        public ushort rSize => 0;
        #endregion

        public x004E()
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
            Id = byteBlock.ReadInt32();
            return byteBlock;
        }

        public void Process(GameSession gameSession)
        {
            throw new NotImplementedException();
        }
    }
}

