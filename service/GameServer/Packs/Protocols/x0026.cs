#pragma warning disable CS8618

using TouchSocket.Core;
using GameServer.Service;

namespace GameServer.Packs.Protocol
{
    /// <summary>
    /// <para>ToggleAttackMode</para>
    /// <para>ToggleAttackMode</para>
    /// </summary>
    internal class x0026 : Package
    {
        #region public field

		public Byte AttackMode;
        #endregion

        #region public attribute

        public ushort Type => 0x0026;
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
			AttackMode = byteBlock.ReadByte();
            return byteBlock;
        }

        public void Process(GameSession session)
        {
            
        }
    }
}

