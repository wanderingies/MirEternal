#pragma warning disable CS8618

using TouchSocket.Core;
using WorldServer.Service;

namespace WorldServer.Packs.Protocol
{
    /// <summary>
    /// <para>同步PK惩罚值</para>
    /// <para>同步对象惩罚</para>
    /// </summary>
    internal class x0050 : Package
    {
        #region public field

		public Int32 对象编号;
		public Int32 PK值惩罚;
        #endregion

        #region public attribute

        public ushort Type => 0x0050;
        public ushort Size => 10;        
        #endregion
        
        #region private field


        #endregion

        public ByteBlock Marshal(ByteBlock byteBlock)
        {
			byteBlock.Write(对象编号);
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

