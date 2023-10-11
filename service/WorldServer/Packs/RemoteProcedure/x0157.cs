#pragma warning disable CS8618

using TouchSocket.Core;
using WorldServer.Service;

namespace WorldServer.Packs.Protocol
{
    /// <summary>
    /// <para>FixMaxPersistentPacket</para>
    /// <para>FixMaxPersistentPacket</para>
    /// </summary>
    internal class x0157 : Package
    {
        #region public field

		public Boolean 修复失败;
        #endregion

        #region public attribute

        public ushort Type => 0x0157;
        public ushort Size => 3;        
        #endregion
        
        #region private field


        #endregion

        public ByteBlock Marshal(ByteBlock byteBlock)
        {
			byteBlock.Write(修复失败);
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

