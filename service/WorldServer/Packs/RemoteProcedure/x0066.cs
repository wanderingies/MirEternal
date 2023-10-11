#pragma warning disable CS8618

using TouchSocket.Core;
using WorldServer.Service;

namespace WorldServer.Packs.Protocol
{
    /// <summary>
    /// <para>UnlockInscriptionSlotPacket</para>
    /// <para>UnlockInscriptionSlotPacket</para>
    /// </summary>
    internal class x0066 : Package
    {
        #region public field

		public Byte 解锁参数;
        #endregion

        #region public attribute

        public ushort Type => 0x0066;
        public ushort Size => 3;        
        #endregion
        
        #region private field


        #endregion

        public ByteBlock Marshal(ByteBlock byteBlock)
        {
			byteBlock.Write(解锁参数);
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

