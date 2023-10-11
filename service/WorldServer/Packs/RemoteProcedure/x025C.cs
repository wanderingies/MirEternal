#pragma warning disable CS8618

using TouchSocket.Core;
using WorldServer.Service;

namespace WorldServer.Packs.Protocol
{
    /// <summary>
    /// <para>PropertyChangeNotificationPacket</para>
    /// <para>PropertyChangeNotificationPacket</para>
    /// </summary>
    internal class x025C : Package
    {
        #region public field

		public Int32 Stat类型;
		public Int32 Value;
        #endregion

        #region public attribute

        public ushort Type => 0x025C;
        public ushort Size => 10;        
        #endregion
        
        #region private field


        #endregion

        public ByteBlock Marshal(ByteBlock byteBlock)
        {
			byteBlock.Write(Stat类型);
			byteBlock.Write(Value);
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

