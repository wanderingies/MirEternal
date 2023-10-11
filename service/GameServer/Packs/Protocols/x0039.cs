#pragma warning disable CS8618

using TouchSocket.Core;
using GameServer.Service;

namespace GameServer.Packs.Protocol
{
    /// <summary>
    /// <para>玩家扩展背包</para>
    /// <para>玩家扩展背包</para>
    /// </summary>
    internal class x0039 : Package
    {
        #region public field

		public Byte 背包类型;
		public Byte 扩展大小;
        #endregion

        #region public attribute

        public ushort Type => 0x0039;
        public ushort Size => 4;        
        #endregion
        
        #region private field


        #endregion

        public ByteBlock Marshal(ByteBlock byteBlock)
        {
            return byteBlock;
        }

        public ByteBlock UnMarshal(ByteBlock byteBlock)
        {
			背包类型 = byteBlock.ReadByte();
			扩展大小 = byteBlock.ReadByte();
            return byteBlock;
        }

        public void Process(GameSession session)
        {
            
        }
    }
}

