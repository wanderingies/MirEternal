﻿#pragma warning disable CS8618

using TouchSocket.Core;
using GameServer.Service;

namespace GameServer.Packs.Protocols
{
    /// <summary>
    /// <para>玩家装配称号</para>
    /// <para>玩家装配称号</para>
    /// </summary>
    internal class x0091 : Package
    {
        #region public

        public byte Id;
        #endregion

        #region marshal


        #endregion

        #region attribute

        public ushort Type => 0x0091;
        public ushort Size => 3;
        public ushort rSize => 0;
        #endregion

        public x0091()
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
            Id = byteBlock.ReadByte();
            return byteBlock;
        }

        public void Process(GameSession gameSession)
        {
            throw new NotImplementedException();
        }
    }
}

