#pragma warning disable CS8618

using TouchSocket.Core;
using GameServer.Service;

namespace GameServer.Packs.Protocol
{
    /// <summary>
    /// <para>玩家同意交易</para>
    /// <para>玩家同意交易</para>
    /// </summary>
    internal class x0094 : Package
    {
        #region public field

		public Int32 对象编号;

        public Byte U1;
        public byte[] Result;
        #endregion

        #region public attribute

        public ushort Type => 0x0094;
        public ushort Size => 6;        
        #endregion

        public x0094()
        {
            Result = new byte[] { 0 };
        }

        #region private field


        #endregion

        public ByteBlock Marshal(ByteBlock byteBlock)
        {
            return byteBlock;
        }

        public ByteBlock UnMarshal(ByteBlock byteBlock)
        {
			对象编号 = byteBlock.ReadInt32();
            return byteBlock;
        }

        public void Process(GameSession session)
        {
            
        }
    }
}

