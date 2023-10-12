#pragma warning disable CS8618

using TouchSocket.Core;
using WorldServer.Service;

namespace WorldServer.Packs.Protocol
{
    /// <summary>
    /// <para>复活信息(无此封包不会弹出复活框)</para>
    /// <para>SendResurrectionMessagePacket</para>
    /// </summary>
    internal class x0039 : Package
    {
        #region public field

		public byte[] 复活描述;
        #endregion

        #region public attribute

        public ushort Type => 0x0039;
        public ushort Size => 55;        
        #endregion
        
        #region private field


        #endregion

        public ByteBlock Marshal(ByteBlock byteBlock)
        {
			byteBlock.Write(复活描述);
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

