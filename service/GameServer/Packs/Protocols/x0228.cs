#pragma warning disable CS8618

using TouchSocket.Core;
using GameServer.Service;

namespace GameServer.Packs.Protocol
{
    /// <summary>
    /// <para>查询GuildName</para>
    /// <para>查询GuildName</para>
    /// </summary>
    internal class x0228 : Package
    {
        #region public

		public Int32 行会编号;
		public Int32 状态编号;
        #endregion

        #region marshal


        #endregion

        #region attribute

        public ushort Type => 0x0228;
        public ushort Size => 10;     
        public ushort rSize => 0;
        #endregion
        
        public x0228() 
        {
        }

        #region private


        #endregion

        public ByteBlock Marshal(ByteBlock byteBlock)
        {
            throw new NotImplementedException();
        }

        public ByteBlock UnMarshal(ByteBlock byteBlock)
        {
			行会编号 = byteBlock.ReadInt32();
			状态编号 = byteBlock.ReadInt32();
			return byteBlock;
        }

        public void Process(GameSession gameSession)
        {
            throw new NotImplementedException();
        }
    }
}

