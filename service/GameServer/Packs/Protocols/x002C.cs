﻿#pragma warning disable CS8618

using TouchSocket.Core;
using GameServer.Service;

namespace GameServer.Packs.Protocol
{
    /// <summary>
    /// <para>物品转移/交换/合并/更换装备</para>
    /// <para>CharacterTransferItemPacket</para>
    /// </summary>
    internal class x002C : Package
    {
        #region public field

		public Byte 当前背包;
		public Byte 原有位置;
		public Byte 目标背包;
		public Byte 目标位置;
        #endregion

        #region public attribute

        public ushort Type => 0x002C;
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
			当前背包 = byteBlock.ReadByte();
			原有位置 = byteBlock.ReadByte();
			目标背包 = byteBlock.ReadByte();
			目标位置 = byteBlock.ReadByte();
            return byteBlock;
        }

        public void Process(GameSession session)
        {
            
        }
    }
}
