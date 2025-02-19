﻿#pragma warning disable CS8618

using TouchSocket.Core;
using GameServer.Service;

namespace GameServer.Packs.Protocols
{
    /// <summary>
    /// <para>CharacterPickupItemsPacket</para>
    /// <para>CharacterPickupItemsPacket</para>
    /// </summary>
    internal class x0030 : Package
    {
        #region public

        public int Id;
        #endregion

        #region marshal


        #endregion

        #region attribute

        public ushort Type => 0x0030;
        public ushort Size => 7;
        public ushort rSize => 0;
        #endregion

        public x0030()
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
            Id = byteBlock.ReadInt32();
            return byteBlock;
        }

        public void Process(GameSession gameSession)
        {
            throw new NotImplementedException();
        }
    }
}

