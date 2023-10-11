#pragma warning disable CS8618

using TouchSocket.Core;
using WorldServer.Service;

namespace WorldServer.Packs.Protocol
{
    /// <summary>
    /// <para>确认替换铭文</para>
    /// <para>确认替换铭文</para>
    /// </summary>
    internal class x0109 : Package
    {
        #region public field

		public Boolean 确定替换;
        #endregion

        #region public attribute

        public ushort Type => 0x0109;
        public ushort Size => 3;        
        #endregion
        
        #region private field


        #endregion

        public ByteBlock Marshal(ByteBlock byteBlock)
        {
			byteBlock.Write(确定替换);
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

