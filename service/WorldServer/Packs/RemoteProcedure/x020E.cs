#pragma warning disable CS8618

using TouchSocket.Core;
using WorldServer.Service;

namespace WorldServer.Packs.Protocol
{
    /// <summary>
    /// <para>查询对象队伍信息回应</para>
    /// <para>查询队伍应答</para>
    /// </summary>
    internal class x020E : Package
    {
        #region public field

		public Int32 队伍编号;
		public String 队伍名字;
		public Int32 队长编号;
        #endregion

        #region public attribute

        public ushort Type => 0x020E;
        public ushort Size => 43;        
        #endregion
        
        #region private field


        #endregion

        public ByteBlock Marshal(ByteBlock byteBlock)
        {
			byteBlock.Write(队伍编号);
			byteBlock.Write(队伍名字);
			byteBlock.Write(队长编号);
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

