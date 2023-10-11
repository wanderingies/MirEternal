#pragma warning disable CS8618

using TouchSocket.Core;
using GameServer.Service;

namespace GameServer.Packs.Protocol
{
    /// <summary>
    /// <para>查询排名榜单</para>
    /// <para>查询排名榜单</para>
    /// </summary>
    internal class x025C : Package
    {
        #region public field

		public Int32 榜单类型;
		public Int32 起始位置;
        #endregion

        #region public attribute

        public ushort Type => 0x025C;
        public ushort Size => 10;        
        #endregion
        
        #region private field


        #endregion

        public ByteBlock Marshal(ByteBlock byteBlock)
        {
            return byteBlock;
        }

        public ByteBlock UnMarshal(ByteBlock byteBlock)
        {
			榜单类型 = byteBlock.ReadInt32();
			起始位置 = byteBlock.ReadInt32();
            return byteBlock;
        }

        public void Process(GameSession session)
        {
            
        }
    }
}

