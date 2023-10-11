#pragma warning disable CS8618

using TouchSocket.Core;
using WorldServer.Service;

namespace WorldServer.Packs.Protocol
{
    /// <summary>
    /// <para>高级铭文洗练</para>
    /// <para>玩家高级洗练</para>
    /// </summary>
    internal class x0108 : Package
    {
        #region public field

		public UInt16 洗练结果;
		public UInt16 铭文位一;
		public UInt16 铭文位二;
        #endregion

        #region public attribute

        public ushort Type => 0x0108;
        public ushort Size => 16;        
        #endregion
        
        #region private field


        #endregion

        public ByteBlock Marshal(ByteBlock byteBlock)
        {
			byteBlock.Write(洗练结果);
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

