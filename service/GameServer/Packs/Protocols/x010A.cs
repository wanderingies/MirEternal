﻿#pragma warning disable CS8618

using TouchSocket.Core;
using GameServer.Service;

namespace GameServer.Packs.Protocols
{
    /// <summary>
    /// <para>Unknown266</para>
    /// <para>UnknownC266</para>
    /// </summary>
    internal class x010A : Package
    {
        #region public

        #endregion

        #region marshal


        #endregion

        #region attribute

        public ushort Type => 0x010A;
        public ushort Size => 11;
        public ushort rSize => 0;
        #endregion

        public x010A()
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
            return byteBlock;
        }

        public void Process(GameSession gameSession)
        {
            Program.service.Logger.Warning($"0x010A => The method or operation is not implemented.");
        }
    }
}

