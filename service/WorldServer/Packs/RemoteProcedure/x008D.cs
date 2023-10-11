#pragma warning disable CS8618

using TouchSocket.Core;
using WorldServer.Service;

namespace WorldServer.Packs.Protocol
{
    /// <summary>
    /// <para>武器幸运变化</para>
    /// <para>武器幸运变化</para>
    /// </summary>
    internal class x008D : Package
    {
        #region public field

		public SByte 幸运变化;
        #endregion

        #region public attribute

        public ushort Type => 0x008D;
        public ushort Size => 4;        
        #endregion
        
        #region private field


        #endregion

        public ByteBlock Marshal(ByteBlock byteBlock)
        {
			byteBlock.Write(幸运变化);
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

