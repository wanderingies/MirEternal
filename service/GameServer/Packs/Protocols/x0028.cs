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
        #region public

		public Boolean 切回正常姿态;
		public Boolean 系统自动切换;
        #endregion

        #region marshal


        #endregion

        #region attribute

        public ushort Type => 0x0028;
        public ushort Size => 4;     
        public ushort rSize => 0;
        #endregion
        
        public x0028() 
        {
        }

        #region private


        #endregion

        public ByteBlock Marshal(ByteBlock byteBlock)
        {
            throw new NotImplementedException();
        }

        public ByteBlock UnMarshal(ByteBlock byteBlock)
        {
			切回正常姿态 = byteBlock.ReadBoolean();
			系统自动切换 = byteBlock.ReadBoolean();
			return byteBlock;
        }

        public void Process(GameSession gameSession)
        {
            throw new NotImplementedException();
        }
    }
}

