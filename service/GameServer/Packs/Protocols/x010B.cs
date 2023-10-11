#pragma warning disable CS8618

using TouchSocket.Core;
using GameServer.Service;

namespace GameServer.Packs.Protocol
{
    /// <summary>
    /// <para>UnknownC267</para>
    /// <para>UnknownC267</para>
    /// </summary>
    internal class x010B : Package
    {
        #region public field

		public Int32 U1;
        #endregion

        #region public attribute

        public ushort Type => 0x010B;
        public ushort Size => 142;        
        #endregion
        
        #region private field


        #endregion

        public ByteBlock Marshal(ByteBlock byteBlock)
        {
            return byteBlock;
        }

        public ByteBlock UnMarshal(ByteBlock byteBlock)
        {
			U1 = byteBlock.ReadInt32();
            return byteBlock;
        }

        public void Process(GameSession session)
        {
            
        }
    }
}

