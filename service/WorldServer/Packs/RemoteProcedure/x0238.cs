﻿#pragma warning disable CS8618

using TouchSocket.Core;
using WorldServer.Service;

namespace WorldServer.Packs.Protocol
{
    /// <summary>
    /// <para>RemoveApprenticePromptPacket</para>
    /// <para>RemoveApprenticePromptPacket</para>
    /// </summary>
    internal class x0238 : Package
    {
        #region public field

		public Int32 对象编号;
        #endregion

        #region public attribute

        public ushort Type => 0x0238;
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
