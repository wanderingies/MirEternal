﻿#pragma warning disable CS8618

using TouchSocket.Core;
using WorldServer.Service;

namespace WorldServer.Packs.Protocol
{
    /// <summary>
    /// <para>RefusalApprenticePacket</para>
    /// <para>RefusalApprenticePacket</para>
    /// </summary>
    internal class x0229 : Package
    {
        #region public field

		public Int32 对象编号;
        #endregion

        #region public attribute

        public ushort Type => 0x0229;
        public ushort Size => 6;        
        #endregion
        
        #region private field


        #endregion

        public ByteBlock Marshal(ByteBlock byteBlock)
        {
			byteBlock.Write(对象编号);
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
