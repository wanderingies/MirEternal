﻿#pragma warning disable CS8618

using TouchSocket.Core;
using GameServer.Service;

namespace GameServer.Packs.Protocol
{
    /// <summary>
    /// <para>ReplaceLowLevelInscriptionsPacket</para>
    /// <para>ReplaceLowLevelInscriptionsPacket</para>
    /// </summary>
    internal class x004D : Package
    {
        #region public field

		public Byte 装备类型;
		public Byte 装备位置;
        #endregion

        #region public attribute

        public ushort Type => 0x004D;
        public ushort Size => 4;        
        #endregion
        
        #region private field


        #endregion

        public ByteBlock Marshal(ByteBlock byteBlock)
        {
            return byteBlock;
        }

        public ByteBlock UnMarshal(ByteBlock byteBlock)
        {
			装备类型 = byteBlock.ReadByte();
			装备位置 = byteBlock.ReadByte();
            return byteBlock;
        }

        public void Process(GameSession session)
        {
            
        }
    }
}
