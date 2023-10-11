#pragma warning disable CS8618

using TouchSocket.Core;
using GameServer.Service;

namespace GameServer.Packs.Protocol
{
    /// <summary>
    /// <para>测试网关网速</para>
    /// <para>TestNetworkSpeedPacket</para>
    /// </summary>
    internal class x03EF : Package
    {
        #region public field

		public Int32 ClientTime;
        #endregion

        #region public attribute

        public ushort Type => 0x03EF;
        public ushort Size => 6;        
        #endregion
        
        #region private field


        #endregion

        public ByteBlock Marshal(ByteBlock byteBlock)
        {
            return byteBlock;
        }

        public ByteBlock UnMarshal(ByteBlock byteBlock)
        {
			ClientTime = byteBlock.ReadInt32();
            return byteBlock;
        }

        public void Process(GameSession session)
        {
            
        }
    }
}

