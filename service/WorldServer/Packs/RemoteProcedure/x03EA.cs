﻿#pragma warning disable CS8618

using TouchSocket.Core;
using WorldServer.Service;

namespace WorldServer.Packs.Protocol
{
    /// <summary>
    /// <para>AccountLoginSuccessPacket</para>
    /// <para>AccountLoginSuccessPacket</para>
    /// </summary>
    internal class x03EA : Package
    {
        #region public field

		public byte[] 协议数据;
        #endregion

        #region public attribute

        public ushort Type => 0x03EA;
        public ushort Size => 0;        
        #endregion
        
        #region private field


        #endregion

        public ByteBlock Marshal(ByteBlock byteBlock)
        {
			byteBlock.Write(协议数据);
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

