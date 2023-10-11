#pragma warning disable CS8618

using TouchSocket.Core;
using WorldServer.Service;

namespace WorldServer.Packs.Protocol
{
    /// <summary>
    /// <para>DoubleExpChangePacket</para>
    /// <para>DoubleExpChangePacket</para>
    /// </summary>
    internal class x004C : Package
    {
        #region public field

		public Int32 DoubleExp;
        #endregion

        #region public attribute

        public ushort Type => 0x004C;
        public ushort Size => 6;        
        #endregion
        
        #region private field


        #endregion

        public ByteBlock Marshal(ByteBlock byteBlock)
        {
			byteBlock.Write(DoubleExp);
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

