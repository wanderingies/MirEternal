#pragma warning disable CS8618

using TouchSocket.Core;
using WorldServer.Service;

namespace WorldServer.Packs.Protocol
{
    /// <summary>
    /// <para>EmailDeletedOkPacket</para>
    /// <para>EmailDeletedOkPacket</para>
    /// </summary>
    internal class x0240 : Package
    {
        #region public field

		public Int32 邮件编号;
        #endregion

        #region public attribute

        public ushort Type => 0x0240;
        public ushort Size => 14;        
        #endregion
        
        #region private field


        #endregion

        public ByteBlock Marshal(ByteBlock byteBlock)
        {
			byteBlock.Write(邮件编号);
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

