﻿#pragma warning disable CS8618

using TouchSocket.Core;
using WorldServer.Service;

namespace WorldServer.Packs.Protocol
{
    /// <summary>
    /// <para>GatewayQueryResponsePacket</para>
    /// <para>GatewayQueryResponsePacket</para>
    /// </summary>
    internal class x0001 : Package
    {
        #region public field

        #endregion

        #region public attribute

        public ushort Type => 0x0001;
        public ushort Size => 15;        
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
