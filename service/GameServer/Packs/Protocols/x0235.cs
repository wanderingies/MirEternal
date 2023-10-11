#pragma warning disable CS8618

using TouchSocket.Core;
using GameServer.Service;

namespace GameServer.Packs.Protocol
{
    /// <summary>
    /// <para>变更会员职位</para>
    /// <para>变更会员职位</para>
    /// </summary>
    internal class x0235 : Package
    {
        #region public field

		public Int32 对象编号;
		public Byte 对象职位;
        #endregion

        #region public attribute

        public ushort Type => 0x0235;
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
			对象编号 = byteBlock.ReadInt32();
			对象职位 = byteBlock.ReadByte();
            return byteBlock;
        }

        public void Process(GameSession session)
        {
            
        }
    }
}

