﻿#pragma warning disable CS8618

using TouchSocket.Core;
using GameServer.Service;

namespace GameServer.Packs.Protocols
{
    /// <summary>
    /// <para>上传角色位置</para>
    /// <para>角色状态描述</para>
    /// </summary>
    internal class x000E : Package
    {
        #region public

        public ushort 高度;
        #endregion

        #region marshal

        public byte[] StateInfo;
        #endregion

        #region attribute

        public ushort Type => 0x000E;
        public ushort Size => 10;
        public ushort rSize => 0;
        #endregion

        public x000E()
        {
            StateInfo = new byte[] { 0 };
        }

        #region private


        #endregion

        public ByteBlock Marshal(ByteBlock byteBlock)
        {
            byteBlock.Write(StateInfo);
            return byteBlock;
        }

        public ByteBlock UnMarshal(ByteBlock byteBlock)
        {
            高度 = byteBlock.ReadUInt16();
            return byteBlock;
        }

        public void Process(GameSession gameSession)
        {
            throw new NotImplementedException();
        }
    }
}

