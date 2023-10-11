#pragma warning disable CS8618

using TouchSocket.Core;
using GameServer.Service;

namespace GameServer.Packs.Protocol
{
    /// <summary>
    /// <para>RequestLockStoragePacket</para>
    /// <para>RequestLockStoragePacket</para>
    /// </summary>
    internal class x0062 : Package
    {
        #region public field

		public Boolean Enabled;
        #endregion

        #region public attribute

        public ushort Type => 0x0062;
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
			Enabled = byteBlock.ReadBoolean();
            return byteBlock;
        }

        public void Process(GameSession session)
        {
            
        }
    }
}

