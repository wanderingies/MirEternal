#pragma warning disable CS8618

using TouchSocket.Core;
using WorldServer.Service;

namespace WorldServer.Packs.Protocol
{
    /// <summary>
    /// <para>对象转动</para>
    /// <para>ObjectRotationDirectionPacket</para>
    /// </summary>
    internal class x0032 : Package
    {
        #region public field

		public Int32 对象编号;
		public UInt16 转向耗时;
		public UInt16 对象朝向;
        #endregion

        #region public attribute

        public ushort Type => 0x0032;
        public ushort Size => 10;        
        #endregion
        
        #region private field


        #endregion

        public ByteBlock Marshal(ByteBlock byteBlock)
        {
			byteBlock.Write(对象编号);
			byteBlock.Write(转向耗时);
			byteBlock.Write(对象朝向);
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

