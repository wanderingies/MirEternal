﻿#pragma warning disable CS8618

using TouchSocket.Core;
using GameServer.Service;
using GameServer.Utility;

namespace GameServer.Packs.Protocol
{
    /// <summary>
    /// <para>CharacterUseItemsPacket</para>
    /// <para>CharacterUseItemsPacket</para>
    /// </summary>
    internal class x002D : Package
    {
        #region public field

		public Byte 背包类型;
		public Byte 物品位置;

        public Int32 Synchronisedtime;
        #endregion

        #region public attribute

        public ushort Type => 0x002D;
        public ushort Size => 4;        
        #endregion
        
        #region private field


        #endregion

        public ByteBlock Marshal(ByteBlock byteBlock)
        {
            byteBlock.Write(UtilityLibrary.TimeShift(DateTime.Now));
            return byteBlock;
        }

        public ByteBlock UnMarshal(ByteBlock byteBlock)
        {
			背包类型 = byteBlock.ReadByte();
			物品位置 = byteBlock.ReadByte();
            return byteBlock;
        }

        public void Process(GameSession session)
        {
            
        }
    }
}
