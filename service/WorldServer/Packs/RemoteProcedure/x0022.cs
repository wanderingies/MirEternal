﻿#pragma warning disable CS8618

using TouchSocket.Core;
using WorldServer.Service;

namespace WorldServer.Packs.Protocol
{
    /// <summary>
    /// <para>SyncPlayerAttributesPacket</para>
    /// <para>SyncPlayerAttributesPacket</para>
    /// </summary>
    internal class x0022 : Package
    {
        #region public field

		public Int32 对象编号;
		public Int32 Stat数量;
        #endregion

        #region public attribute

        public ushort Type => 0x0022;
        public ushort Size => 0;        
        #endregion
        
        #region private field


        #endregion

        public ByteBlock Marshal(ByteBlock byteBlock)
        {
			byteBlock.Write(对象编号);
			byteBlock.Write(Stat数量);
            return byteBlock;
        }

        public ByteBlock UnMarshal(ByteBlock byteBlock)
        {
            return byteBlock;
        }

        public void Process(WorldSession session)
        {
            
        }
    }
}
