﻿#pragma warning disable CS8618

using TouchSocket.Core;
using GameServer.Service;

namespace GameServer.Packs.Protocol
{
    /// <summary>
    /// <para>回应组队请求</para>
    /// <para>回应组队请求</para>
    /// </summary>
    internal class x00ED : Package
    {
        #region public field

		public Int32 对象编号;
		public Byte 组队方式;
		public Byte 回应方式;
        #endregion

        #region public attribute

        public ushort Type => 0x00ED;
        public ushort Size => 8;        
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
			组队方式 = byteBlock.ReadByte();
			回应方式 = byteBlock.ReadByte();
            return byteBlock;
        }

        public void Process(GameSession session)
        {
            
        }
    }
}
