#pragma warning disable CS8618

using TouchSocket.Core;
using GameServer.Service;

namespace GameServer.Packs.Protocol
{
    /// <summary>
    /// <para>处理入会邀请</para>
    /// <para>处理入会邀请</para>
    /// </summary>
    internal class x0230 : Package
    {
        #region public field

		public Byte 处理类型;
		public Int32 对象编号;
        #endregion

        #region public attribute

        public ushort Type => 0x0230;
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
			处理类型 = byteBlock.ReadByte();
			对象编号 = byteBlock.ReadInt32();
            return byteBlock;
        }

        public void Process(GameSession session)
        {
            
        }
    }
}

