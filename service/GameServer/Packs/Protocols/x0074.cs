﻿#pragma warning disable CS8618

using TouchSocket.Core;
using GameServer.Service;

namespace GameServer.Packs.Protocol
{
    /// <summary>
    /// <para>OpenChestPacket</para>
    /// <para>OpenChestPacket</para>
    /// </summary>
    internal class x0074 : Package
    {
        #region public field

		public Int32 ObjectId;
        #endregion

        #region public attribute

        public ushort Type => 0x0074;
        public ushort Size => 6;        
        #endregion
        
        #region private field


        #endregion

        public ByteBlock Marshal(ByteBlock byteBlock)
        {
            return byteBlock;
        }

        public ByteBlock UnMarshal(ByteBlock byteBlock)
        {
			ObjectId = byteBlock.ReadInt32();
            return byteBlock;
        }

        public void Process(GameSession session)
        {
            
        }
    }
}
