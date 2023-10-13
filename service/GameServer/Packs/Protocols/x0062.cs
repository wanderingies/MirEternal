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
        #region public

		public Boolean Enabled;
        #endregion

        #region marshal


        #endregion

        #region attribute

        public ushort Type => 0x0062;
        public ushort Size => 3;     
        public ushort rSize => 0;
        #endregion
        
        public x0062() 
        {
        }

        #region private


        #endregion

        public ByteBlock Marshal(ByteBlock byteBlock)
        {
            throw new NotImplementedException();
        }

        public ByteBlock UnMarshal(ByteBlock byteBlock)
        {
			Enabled = byteBlock.ReadBoolean();
			return byteBlock;
        }

        public void Process(GameSession gameSession)
        {
            throw new NotImplementedException();
        }
    }
}

