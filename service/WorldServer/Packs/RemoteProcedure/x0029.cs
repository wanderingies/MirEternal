#pragma warning disable CS8618

using TouchSocket.Core;
using WorldServer.Service;

namespace WorldServer.Packs.Protocol
{
    /// <summary>
    /// <para>切换地图(回城/过图/传送)</para>
    /// <para>玩家切换地图</para>
    /// </summary>
    internal class x0029 : Package
    {
        #region public field

		public Int32 MapId;
		public Int32 路线编号;
		public UInt16 对象高度;
        #endregion

        #region public attribute

        public ushort Type => 0x0029;
        public ushort Size => 23;        
        #endregion
        
        #region private field


        #endregion

        public ByteBlock Marshal(ByteBlock byteBlock)
        {
			byteBlock.Write(MapId);
			byteBlock.Write(路线编号);
			byteBlock.Write(对象高度);
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

