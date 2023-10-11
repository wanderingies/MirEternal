#pragma warning disable CS8618

using TouchSocket.Core;
using WorldServer.Service;

namespace WorldServer.Packs.Protocol
{
    /// <summary>
    /// <para>处理结盟申请</para>
    /// <para>AffiliateAppResponsePacket</para>
    /// </summary>
    internal class x025F : Package
    {
        #region public field

		public Int32 行会编号;
        #endregion

        #region public attribute

        public ushort Type => 0x025F;
        public ushort Size => 6;        
        #endregion
        
        #region private field


        #endregion

        public ByteBlock Marshal(ByteBlock byteBlock)
        {
			byteBlock.Write(行会编号);
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

