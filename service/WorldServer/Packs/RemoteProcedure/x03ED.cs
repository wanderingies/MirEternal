﻿#pragma warning disable CS8618

using TouchSocket.Core;
using WorldServer.Service;

namespace WorldServer.Packs.Protocol
{
    /// <summary>
    /// <para>CharacterCreatedSuccessfullyPacket</para>
    /// <para>CharacterCreatedSuccessfullyPacket</para>
    /// </summary>
    internal class x03ED : Package
    {
        #region public field

        #endregion

        #region public attribute

        public ushort Type => 0x03ED;
        public ushort Size => 96;        
        #endregion
        
        #region private field


        #endregion

        public ByteBlock Marshal(ByteBlock byteBlock)
        {
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
