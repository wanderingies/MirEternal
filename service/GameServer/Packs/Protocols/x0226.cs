#pragma warning disable CS8618

using TouchSocket.Core;
using GameServer.Service;

namespace GameServer.Packs.Protocol
{
    /// <summary>
    /// <para>删除指定邮件</para>
    /// <para>删除指定邮件</para>
    /// </summary>
    internal class x0226 : Package
    {
        #region public field

		public Int32 邮件编号;
        #endregion

        #region public attribute

        public ushort Type => 0x0226;
        public ushort Size => 14;        
        #endregion
        
        #region private field


        #endregion

        public ByteBlock Marshal(ByteBlock byteBlock)
        {
            return byteBlock;
        }

        public ByteBlock UnMarshal(ByteBlock byteBlock)
        {
			邮件编号 = byteBlock.ReadInt32();
            return byteBlock;
        }

        public void Process(GameSession session)
        {
            
        }
    }
}

