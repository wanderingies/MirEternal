﻿#pragma warning disable CS8618

using TouchSocket.Core;
using GameServer.Service;

namespace GameServer.Packs.Protocols
{
    /// <summary>
    /// <para>查询出售信息</para>
    /// <para>查询出售信息</para>
    /// </summary>
    internal class x025A : Package
    {
        #region public

        #endregion

        #region marshal


        #endregion

        #region attribute

        public ushort Type => 0x025A;
        public ushort Size => 2;
        public ushort rSize => 0;
        #endregion

        public x025A()
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
            throw new NotImplementedException();
        }

        public void Process(GameSession gameSession)
        {
            throw new NotImplementedException();
        }
    }
}

