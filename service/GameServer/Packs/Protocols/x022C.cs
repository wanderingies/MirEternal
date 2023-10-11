#pragma warning disable CS8618

using TouchSocket.Core;
using GameServer.Service;

namespace GameServer.Packs.Protocol
{
    /// <summary>
    /// <para>申请加入行会</para>
    /// <para>申请加入行会</para>
    /// </summary>
    internal class x022C : Package
    {
        #region public field

		public Int32 行会编号;
		public String GuildName;
        #endregion

        #region public attribute

        public ushort Type => 0x022C;
        public ushort Size => 31;        
        #endregion
        
        #region private field


        #endregion

        public ByteBlock Marshal(ByteBlock byteBlock)
        {
            return byteBlock;
        }

        public ByteBlock UnMarshal(ByteBlock byteBlock)
        {
			行会编号 = byteBlock.ReadInt32();
            return byteBlock;
        }

        public void Process(GameSession session)
        {
            
        }
    }
}

