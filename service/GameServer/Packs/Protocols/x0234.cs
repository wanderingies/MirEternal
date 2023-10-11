#pragma warning disable CS8618

using TouchSocket.Core;
using GameServer.Service;

namespace GameServer.Packs.Protocol
{
    /// <summary>
    /// <para>设置行会禁言</para>
    /// <para>设置行会禁言</para>
    /// </summary>
    internal class x0234 : Package
    {
        #region public field

		public Byte 禁言状态;
		public Int32 对象编号;
        #endregion

        #region public attribute

        public ushort Type => 0x0234;
        public ushort Size => 7;        
        #endregion
        
        #region private field


        #endregion

        public ByteBlock Marshal(ByteBlock byteBlock)
        {
            return byteBlock;
        }

        public ByteBlock UnMarshal(ByteBlock byteBlock)
        {
			禁言状态 = byteBlock.ReadByte();
			对象编号 = byteBlock.ReadInt32();
            return byteBlock;
        }

        public void Process(GameSession session)
        {
            
        }
    }
}

