#pragma warning disable CS8618

using TouchSocket.Core;
using GameServer.Service;

namespace GameServer.Packs.Protocol
{
    /// <summary>
    /// <para>GetCurrentMountPacket</para>
    /// <para>GetCurrentMountPacket</para>
    /// </summary>
    internal class x00DA : Package
    {
        #region public field

		public Byte SelectedMountId;
        #endregion

        #region public attribute

        public ushort Type => 0x00DA;
        public ushort Size => 3;        
        #endregion
        
        #region private field


        #endregion

        public ByteBlock Marshal(ByteBlock byteBlock)
        {
            return byteBlock;
        }

        public ByteBlock UnMarshal(ByteBlock byteBlock)
        {
			SelectedMountId = byteBlock.ReadByte();
            return byteBlock;
        }

        public void Process(GameSession session)
        {
            
        }
    }
}

