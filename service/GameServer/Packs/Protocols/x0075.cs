﻿#pragma warning disable CS8618

using TouchSocket.Core;
using GameServer.Service;

namespace GameServer.Packs.Protocol
{
    /// <summary>
    /// <para>点击Npc开始与之对话</para>
    /// <para>开始Npcc对话</para>
    /// </summary>
    internal class x0075 : Package
    {
        #region public field

		public Int32 对象编号;
        #endregion

        #region public attribute

        public ushort Type => 0x0075;
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
