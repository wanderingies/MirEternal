#pragma warning disable CS8618

using TouchSocket.Core;
using GameServer.Service;

namespace GameServer.Packs.Protocol
{
    /// <summary>
    /// <para>BookMarfaPrivilegesPacket</para>
    /// <para>BookMarfaPrivilegesPacket</para>
    /// </summary>
    internal class x00D9 : Package
    {
        #region public field

		public Byte 特权类型;
        #endregion

        #region public attribute

        public ushort Type => 0x00D9;
        public ushort Size => 3;        
        #endregion
        
        #region private field


        #endregion

        public ByteBlock Marshal(ByteBlock byteBlock)
        {
            return byteBlock;
        }

        public ByteBlock UnMarshal(ByteBlock byteBlock)
        {
			特权类型 = byteBlock.ReadByte();
            return byteBlock;
        }

        public void Process(GameSession session)
        {
            
        }
    }
}

