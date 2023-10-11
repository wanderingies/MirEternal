#pragma warning disable CS8618

using TouchSocket.Core;
using WorldServer.Service;

namespace WorldServer.Packs.Protocol
{
    /// <summary>
    /// <para>DoubleInscriptionPositionSwitchPacket</para>
    /// <para>DoubleInscriptionPositionSwitchPacket</para>
    /// </summary>
    internal class x010B : Package
    {
        #region public field

		public UInt16 当前栏位;
		public UInt16 第一铭文;
		public UInt16 第二铭文;
        #endregion

        #region public attribute

        public ushort Type => 0x010B;
        public ushort Size => 8;        
        #endregion
        
        #region private field


        #endregion

        public ByteBlock Marshal(ByteBlock byteBlock)
        {
			byteBlock.Write(当前栏位);
			byteBlock.Write(第一铭文);
			byteBlock.Write(第二铭文);
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

