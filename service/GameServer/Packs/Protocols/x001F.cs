﻿#pragma warning disable CS8618

using TouchSocket.Core;
using GameServer.Service;

namespace GameServer.Packs.Protocol
{
    /// <summary>
    /// <para>CharacterSelectionTargetPacket</para>
    /// <para>CharacterSelectionTargetPacket</para>
    /// </summary>
    internal class x001F : Package
    {
        #region public field

		public Int32 对象编号;
        #endregion

        #region public attribute

        public ushort Type => 0x001F;
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
			对象编号 = byteBlock.ReadInt32();
            return byteBlock;
        }

        public void Process(GameSession session)
        {
            
        }
    }
}
