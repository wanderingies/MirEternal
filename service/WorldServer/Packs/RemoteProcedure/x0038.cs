#pragma warning disable CS8618

using TouchSocket.Core;
using WorldServer.Service;

namespace WorldServer.Packs.Protocol
{
    /// <summary>
    /// <para>角色复活</para>
    /// <para>玩家角色复活</para>
    /// </summary>
    internal class x0038 : Package
    {
        #region public field

		public Int32 对象编号;
		public Byte 复活方式;
        #endregion

        #region public attribute

        public ushort Type => 0x0038;
        public ushort Size => 7;        
        #endregion
        
        #region private field


        #endregion

        public ByteBlock Marshal(ByteBlock byteBlock)
        {
			byteBlock.Write(对象编号);
			byteBlock.Write(复活方式);
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

