﻿#pragma warning disable CS8618

using TouchSocket.Core;
using WorldServer.Service;

namespace WorldServer.Packs.Protocol
{
    /// <summary>
    /// <para>仓库刷新应答</para>
    /// <para>仓库刷新应答</para>
    /// </summary>
    internal class x0264 : Package
    {
        #region public field

        #endregion

        #region public attribute

        public ushort Type => 0x0264;
        public ushort Size => 0;        
        #endregion
        
        #region private field


        #endregion

        public ByteBlock Marshal(ByteBlock byteBlock)
        {
            return byteBlock;
        }

        public ByteBlock UnMarshal(ByteBlock byteBlock)
        {
            return byteBlock;
        }

        public void Process(WorldSession session)
        {
            
        }
    }
}

