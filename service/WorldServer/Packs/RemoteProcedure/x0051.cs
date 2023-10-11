#pragma warning disable CS8618

using TouchSocket.Core;
using WorldServer.Service;

namespace WorldServer.Packs.Protocol
{
    /// <summary>
    /// <para>发送PK的结果</para>
    /// <para>同步对战结果</para>
    /// </summary>
    internal class x0051 : Package
    {
        #region public field

		public Byte 击杀方式;
		public Int32 胜方编号;
		public Int32 败方编号;
		public UInt16 PK值惩罚;
        #endregion

        #region public attribute

        public ushort Type => 0x0051;
        public ushort Size => 13;        
        #endregion
        
        #region private field


        #endregion

        public ByteBlock Marshal(ByteBlock byteBlock)
        {
			byteBlock.Write(击杀方式);
			byteBlock.Write(胜方编号);
			byteBlock.Write(败方编号);
			byteBlock.Write(PK值惩罚);
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

