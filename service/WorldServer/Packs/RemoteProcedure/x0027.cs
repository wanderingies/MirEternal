#pragma warning disable CS8618

using TouchSocket.Core;
using WorldServer.Service;

namespace WorldServer.Packs.Protocol
{
    /// <summary>
    /// <para>进入场景(包括商店/随机卷)</para>
    /// <para>玩家进入场景</para>
    /// </summary>
    internal class x0027 : Package
    {
        #region public field

		public Int32 MapId;
		public Int32 路线编号;
		public Byte RouteStatus;
		public UInt16 当前高度;
        #endregion

        #region public attribute

        public ushort Type => 0x0027;
        public ushort Size => 17;        
        #endregion
        
        #region private field


        #endregion

        public ByteBlock Marshal(ByteBlock byteBlock)
        {
			byteBlock.Write(MapId);
			byteBlock.Write(路线编号);
			byteBlock.Write(RouteStatus);
			byteBlock.Write(当前高度);
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

