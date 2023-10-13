#pragma warning disable CS8618

using TouchSocket.Core;
using GameServer.Service;

namespace GameServer.Packs.Protocol
{
    /// <summary>
    /// <para>OpenChestPacket</para>
    /// <para>OpenChestPacket</para>
    /// </summary>
    internal class x0074 : Package
    {
        #region public

		public Int32 ObjectId;
        #endregion

        #region marshal


        #endregion

        #region attribute

        public ushort Type => 0x0074;
        public ushort Size => 6;     
        public ushort rSize => 0;
        #endregion
        
        public x0074() 
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
			ObjectId = byteBlock.ReadInt32();
			return byteBlock;
        }

        public void Process(GameSession gameSession)
        {
            throw new NotImplementedException();
        }
    }
}

