#pragma warning disable CS8618

using TouchSocket.Core;
using GameServer.Service;

namespace GameServer.Packs.Protocol
{
    /// <summary>
    /// <para>处理解敌申请</para>
    /// <para>处理解敌申请</para>
    /// </summary>
    internal class x0247 : Package
    {
        #region public field

		public Byte 回应类型;
		public Int32 行会编号;
        #endregion

        #region public attribute

        public ushort Type => 0x0247;
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
			回应类型 = byteBlock.ReadByte();
			行会编号 = byteBlock.ReadInt32();
            return byteBlock;
        }

        public void Process(GameSession session)
        {
            
        }
    }
}

