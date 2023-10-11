#pragma warning disable CS8618

using TouchSocket.Core;
using GameServer.Service;

namespace GameServer.Packs.Protocol
{
    /// <summary>
    /// <para>BattleStanceSwitchPacket</para>
    /// <para>BattleStanceSwitchPacket</para>
    /// </summary>
    internal class x0028 : Package
    {
        #region public field

		public Boolean 切回正常姿态;
		public Boolean 系统自动切换;
        #endregion

        #region public attribute

        public ushort Type => 0x0028;
        public ushort Size => 4;        
        #endregion
        
        #region private field


        #endregion

        public ByteBlock Marshal(ByteBlock byteBlock)
        {
            return byteBlock;
        }

        public ByteBlock UnMarshal(ByteBlock byteBlock)
        {
			切回正常姿态 = byteBlock.ReadBoolean();
			系统自动切换 = byteBlock.ReadBoolean();
            return byteBlock;
        }

        public void Process(GameSession session)
        {
            
        }
    }
}

