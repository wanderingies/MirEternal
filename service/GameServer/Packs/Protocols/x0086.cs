#pragma warning disable CS8618

using TouchSocket.Core;
using GameServer.Service;

namespace GameServer.Packs.Protocol
{
    /// <summary>
    /// <para>ToggleMapRoutePacket</para>
    /// <para>ToggleMapRoutePacket</para>
    /// </summary>
    internal class x0086 : Package
    {
        #region public field

		public Byte 地图路线;
        #endregion

        #region public attribute

        public ushort Type => 0x0086;
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
			地图路线 = byteBlock.ReadByte();
            return byteBlock;
        }

        public void Process(GameSession session)
        {
            
        }
    }
}

