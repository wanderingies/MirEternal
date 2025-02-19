﻿#pragma warning disable CS8618

using TouchSocket.Core;
using GameServer.Service;

namespace GameServer.Packs.Protocols
{
    /// <summary>
    /// <para>提交选项继续NPC对话</para>
    /// <para>继续Npcc对话</para>
    /// </summary>
    internal class x0077 : Package
    {
        #region public

        public int Id;
        #endregion

        #region marshal


        #endregion

        #region attribute

        public ushort Type => 0x0077;
        public ushort Size => 6;
        public ushort rSize => 0;
        #endregion

        public x0077()
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

