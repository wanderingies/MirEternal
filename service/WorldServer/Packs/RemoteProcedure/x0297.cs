﻿#pragma warning disable CS8618

using TouchSocket.Core;
using WorldServer.Service;

namespace WorldServer.Packs.Protocol
{
    /// <summary>
    /// <para>GuildSiegeRegistrationPacket</para>
    /// <para>GuildSiegeRegistrationPacket</para>
    /// </summary>
    internal class x0297 : Package
    {
        #region public field

		public Int32 行会编号;
		public Int32 U1;
        #endregion

        #region public attribute

        public ushort Type => 0x0297;
        public ushort Size => 10;        
        #endregion
        
        #region private field


        #endregion

        public ByteBlock Marshal(ByteBlock byteBlock)
        {
			byteBlock.Write(行会编号);
			byteBlock.Write(U1);
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
