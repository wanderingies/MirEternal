﻿#pragma warning disable CS8618

using TouchSocket.Core;
using GameServer.Service;

namespace GameServer.Packs.Protocol
{
    /// <summary>
    /// <para>角色走动</para>
    /// <para>客户角色走动</para>
    /// </summary>
    internal class x0012 : Package
    {
        #region public field

        public byte[] Result;
        #endregion

        #region public attribute

        public ushort Type => 0x0012;
        public ushort Size => 6;        
        #endregion

        public x0012()
        {
            Result = new byte[] { 0 };
        }
        
        #region private field


        #endregion

        public ByteBlock Marshal(ByteBlock byteBlock)
        {
            byteBlock.Write(Result);
            return byteBlock;
        }

        public ByteBlock UnMarshal(ByteBlock byteBlock)
        {
            return byteBlock;
        }

        public void Process(GameSession session)
        {
            
        }
    }
}
