﻿#pragma warning disable CS8618

using TouchSocket.Core;
using GameServer.Service;

namespace GameServer.Packs.Protocol
{
    /// <summary>
    /// <para>ToggleDoubleInscriptionBitPacket</para>
    /// <para>ToggleDoubleInscriptionBitPacket</para>
    /// </summary>
    internal class x004B : Package
    {
        #region public field

		public Byte 装备类型;
		public Byte 装备位置;
		public Byte 操作参数;
        #endregion

        #region public attribute

        public ushort Type => 0x004B;
        public ushort Size => 5;        
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
			操作参数 = byteBlock.ReadByte();
            return byteBlock;
        }

        public void Process(GameSession session)
        {
            
        }
    }
}
