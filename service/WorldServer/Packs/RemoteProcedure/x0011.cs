﻿#pragma warning disable CS8618

using TouchSocket.Core;
using WorldServer.Service;

namespace WorldServer.Packs.Protocol
{
    /// <summary>
    /// <para>SyncBackpackInfoPacket</para>
    /// <para>SyncBackpackInfoPacket</para>
    /// </summary>
    internal class x0011 : Package
    {
        #region public field

		public byte[] 物品描述;
        #endregion

        #region public attribute

        public ushort Type => 0x0011;
        public ushort Size => 0;        
        #endregion
        
        #region private field


        #endregion

        public ByteBlock Marshal(ByteBlock byteBlock)
        {
			byteBlock.Write(物品描述);
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

