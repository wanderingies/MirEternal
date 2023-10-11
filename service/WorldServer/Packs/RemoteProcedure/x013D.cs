#pragma warning disable CS8618

using TouchSocket.Core;
using WorldServer.Service;

namespace WorldServer.Packs.Protocol
{
    /// <summary>
    /// <para>SyncSelectedMount</para>
    /// <para>SyncSelectedMount</para>
    /// </summary>
    internal class x013D : Package
    {
        #region public field

		public Byte SelectedMountId;
        #endregion

        #region public attribute

        public ushort Type => 0x013D;
        public ushort Size => 3;        
        #endregion
        
        #region private field


        #endregion

        public ByteBlock Marshal(ByteBlock byteBlock)
        {
			byteBlock.Write(SelectedMountId);
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

