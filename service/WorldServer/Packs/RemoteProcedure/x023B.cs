#pragma warning disable CS8618

using TouchSocket.Core;
using WorldServer.Service;

namespace WorldServer.Packs.Protocol
{
    /// <summary>
    /// <para>CongratsToApprenticeForAnsweringPacket</para>
    /// <para>CongratsToApprenticeForAnsweringPacket</para>
    /// </summary>
    internal class x023B : Package
    {
        #region public field

		public Int32 徒弟编号;
        #endregion

        #region public attribute

        public ushort Type => 0x023B;
        public ushort Size => 6;        
        #endregion
        
        #region private field


        #endregion

        public ByteBlock Marshal(ByteBlock byteBlock)
        {
			byteBlock.Write(徒弟编号);
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

