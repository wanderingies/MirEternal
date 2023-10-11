#pragma warning disable CS8618

using TouchSocket.Core;
using WorldServer.Service;

namespace WorldServer.Packs.Protocol
{
    /// <summary>
    /// <para>Effect</para>
    /// <para>触发状态效果</para>
    /// </summary>
    internal class x0077 : Package
    {
        #region public field

		public UInt16 Id;
		public Int32 Buff来源;
		public Int32 Buff目标;
		public Int32 血量变化;
        #endregion

        #region public attribute

        public ushort Type => 0x0077;
        public ushort Size => 22;        
        #endregion
        
        #region private field


        #endregion

        public ByteBlock Marshal(ByteBlock byteBlock)
        {
			byteBlock.Write(Id);
			byteBlock.Write(Buff来源);
			byteBlock.Write(Buff目标);
			byteBlock.Write(血量变化);
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

