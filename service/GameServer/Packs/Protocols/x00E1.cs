#pragma warning disable CS8618

using TouchSocket.Core;
using GameServer.Service;

namespace GameServer.Packs.Protocol
{
    /// <summary>
    /// <para>ToggleAwekeningExpPacket</para>
    /// <para>ToggleAwakeningExpPacket</para>
    /// </summary>
    internal class x00E1 : Package
    {
        #region public field

		public Boolean Enabled;
        #endregion

        #region public attribute

        public ushort Type => 0x00E1;
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
			Enabled = byteBlock.ReadBoolean();
            return byteBlock;
        }

        public void Process(GameSession session)
        {
            
        }
    }
}

