#pragma warning disable CS8618

using TouchSocket.Core;
using WorldServer.Service;

namespace WorldServer.Packs.Protocol
{
    /// <summary>
    /// <para>SwitchBattleStancePacket</para>
    /// <para>SwitchBattleStancePacket</para>
    /// </summary>
    internal class x0069 : Package
    {
        #region public field

		public Int32 角色编号;
		public Boolean 切回正常姿态;
		public Boolean 系统自动切换;
        #endregion

        #region public attribute

        public ushort Type => 0x0069;
        public ushort Size => 8;        
        #endregion
        
        #region private field


        #endregion

        public ByteBlock Marshal(ByteBlock byteBlock)
        {
			byteBlock.Write(角色编号);
			byteBlock.Write(切回正常姿态);
			byteBlock.Write(系统自动切换);
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

