﻿#pragma warning disable CS8618

using TouchSocket.Core;
using GameServer.Service;

namespace GameServer.Packs.Protocol
{
    /// <summary>
    /// <para>AddFriendsToFollowPacket</para>
    /// <para>AddFriendsToFollowPacket</para>
    /// </summary>
    internal class x020A : Package
    {
        #region public field

		public Int32 对象编号;
		public String 对象名字;
        #endregion

        #region public attribute

        public ushort Type => 0x020A;
        public ushort Size => 38;        
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
