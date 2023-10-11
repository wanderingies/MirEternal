#pragma warning disable CS8618

using TouchSocket.Core;
using GameServer.Service;

namespace GameServer.Packs.Protocol
{
    /// <summary>
    /// <para>RequestObjectDataPacket, 对应服务端0041封包</para>
    /// <para>RequestObjectDataPacket</para>
    /// </summary>
    internal class x0013 : Package
    {
        #region public field

		public Int32 对象编号;
		public Int32 状态编号;

        public byte[] Result;
        #endregion

        #region public attribute

        public ushort Type => 0x0013;
        public ushort Size => 10;        
        #endregion

        public x0013()
        {
            Result = new byte[] { 0 };
        }
        
        #region private field


        #endregion

        public ByteBlock Marshal(ByteBlock byteBlock)
        {
            byteBlock.Write(Result);
            return byteBlock;
        }

        public ByteBlock UnMarshal(ByteBlock byteBlock)
        {
			对象编号 = byteBlock.ReadInt32();
			状态编号 = byteBlock.ReadInt32();
            return byteBlock;
        }

        public void Process(GameSession session)
        {
            
        }
    }
}

