#pragma warning disable CS8618

using TouchSocket.Core;
using WorldServer.Service;

namespace WorldServer.Packs.Protocol
{
    /// <summary>
    /// <para>OrdinaryInscriptionRefinementPacket</para>
    /// <para>玩家普通洗练</para>
    /// </summary>
    internal class x00FF : Package
    {
        #region public field

		public UInt16 铭文位一;
		public UInt16 铭文位二;
        #endregion

        #region public attribute

        public ushort Type => 0x00FF;
        public ushort Size => 6;        
        #endregion
        
        #region private field


        #endregion

        public ByteBlock Marshal(ByteBlock byteBlock)
        {
			byteBlock.Write(铭文位一);
			byteBlock.Write(铭文位二);
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

