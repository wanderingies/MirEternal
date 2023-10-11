#pragma warning disable CS8618

using TouchSocket.Core;
using GameServer.Service;

namespace GameServer.Packs.Protocol
{
    /// <summary>
    /// <para>申请创建队伍</para>
    /// <para>申请创建队伍</para>
    /// </summary>
    internal class x0209 : Package
    {
        #region public field

		public Int32 对象编号;
		public Byte 分配方式;
        #endregion

        #region public attribute

        public ushort Type => 0x0209;
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
			分配方式 = byteBlock.ReadByte();
            return byteBlock;
        }

        public void Process(GameSession session)
        {
            
        }
    }
}

