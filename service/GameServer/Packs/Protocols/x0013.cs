#pragma warning disable CS8618

using TouchSocket.Core;
using GameServer.Service;

namespace GameServer.Packs.Protocol
{
    /// <summary>
    /// <para>RequestObjectDataPacket, 对应服务端0041封包</para>
    /// <para>快捷栏描述</para>
    /// </summary>
    internal class x0013 : Package
    {
        #region public

		public Int32 对象编号;
		public Int32 状态编号;
        #endregion

        #region marshal

        public byte[] Shortcutbar;
        #endregion

        #region attribute

        public ushort Type => 0x0013;
        public ushort Size => 10;     
        public ushort rSize => 0;
        #endregion
        
        public x0013() 
        {
            Shortcutbar = new byte[] { 0 };
        }

        #region private


        #endregion

        public ByteBlock Marshal(ByteBlock byteBlock)
        {
            byteBlock.Write(Shortcutbar);
            return byteBlock;
        }

        public ByteBlock UnMarshal(ByteBlock byteBlock)
        {
			对象编号 = byteBlock.ReadInt32();
			状态编号 = byteBlock.ReadInt32();
			return byteBlock;
        }

        public void Process(GameSession gameSession)
        {
            throw new NotImplementedException();
        }
    }
}

