#pragma warning disable CS8618

using TouchSocket.Core;
using WorldServer.Service;

namespace WorldServer.Packs.Protocol
{
    /// <summary>
    /// <para>SyncPropChangePacket</para>
    /// <para>SyncPropChangePacket</para>
    /// </summary>
    internal class x004D : Package
    {
        #region public field

		public Byte StatId;
		public Int32 Value;
        #endregion

        #region public attribute

        public ushort Type => 0x004D;
        public ushort Size => 7;        
        #endregion
        
        #region private field


        #endregion

        public ByteBlock Marshal(ByteBlock byteBlock)
        {
			byteBlock.Write(StatId);
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

