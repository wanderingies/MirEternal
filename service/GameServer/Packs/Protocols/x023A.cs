#pragma warning disable CS8618

using TouchSocket.Core;
using GameServer.Service;

namespace GameServer.Packs.Protocol
{
    /// <summary>
    /// <para>处理结盟申请</para>
    /// <para>处理结盟申请</para>
    /// </summary>
    internal class x023A : Package
    {
        #region public field

		public Byte 处理类型;
		public Int32 行会编号;
        #endregion

        #region public attribute

        public ushort Type => 0x023A;
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
			行会编号 = byteBlock.ReadInt32();
            return byteBlock;
        }

        public void Process(GameSession session)
        {
            
        }
    }
}

