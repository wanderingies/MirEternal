﻿#pragma warning disable CS8618

using TouchSocket.Core;
using GameServer.Service;

namespace GameServer.Packs.Protocol
{
    /// <summary>
    /// <para>AbandonInscriptionReplacementPacket</para>
    /// <para>AbandonInscriptionReplacementPacket</para>
    /// </summary>
    internal class x004E : Package
    {
        #region public field

		public Byte 装备类型;
		public Byte 装备位置;
		public Int32 Id;
        #endregion

        #region public attribute

        public ushort Type => 0x004E;
        public ushort Size => 11;        
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
			Id = byteBlock.ReadInt32();
            return byteBlock;
        }

        public void Process(GameSession session)
        {
            
        }
    }
}
