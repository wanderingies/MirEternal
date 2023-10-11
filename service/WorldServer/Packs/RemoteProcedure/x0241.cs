#pragma warning disable CS8618

using TouchSocket.Core;
using WorldServer.Service;

namespace WorldServer.Packs.Protocol
{
    /// <summary>
    /// <para>未读邮件提醒</para>
    /// <para>未读邮件提醒</para>
    /// </summary>
    internal class x0241 : Package
    {
        #region public field

		public Int32 邮件数量;
        #endregion

        #region public attribute

        public ushort Type => 0x0241;
        public ushort Size => 6;        
        #endregion
        
        #region private field


        #endregion

        public ByteBlock Marshal(ByteBlock byteBlock)
        {
			byteBlock.Write(邮件数量);
            return byteBlock;
        }

        public ByteBlock UnMarshal(ByteBlock byteBlock)
        {
            return byteBlock;
        }

        public void Process(WorldSession session)
        {
            
        }
    }
}

