#pragma warning disable CS8618

using TouchSocket.Core;
using WorldServer.Service;

namespace WorldServer.Packs.Protocol
{
    /// <summary>
    /// <para>收徒推送应答</para>
    /// <para>收徒推送应答</para>
    /// </summary>
    internal class x021F : Package
    {
        #region public field

		public Boolean 收徒推送;
        #endregion

        #region public attribute

        public ushort Type => 0x021F;
        public ushort Size => 3;        
        #endregion
        
        #region private field


        #endregion

        public ByteBlock Marshal(ByteBlock byteBlock)
        {
			byteBlock.Write(收徒推送);
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

