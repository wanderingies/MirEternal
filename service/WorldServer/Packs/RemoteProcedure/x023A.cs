#pragma warning disable CS8618

using TouchSocket.Core;
using WorldServer.Service;

namespace WorldServer.Packs.Protocol
{
    /// <summary>
    /// <para>CongratsToApprenticeForUpgradePacket</para>
    /// <para>恭喜徒弟升级</para>
    /// </summary>
    internal class x023A : Package
    {
        #region public field

		public Int32 徒弟编号;
		public Int32 祝贺等级;
        #endregion

        #region public attribute

        public ushort Type => 0x023A;
        public ushort Size => 7;        
        #endregion
        
        #region private field


        #endregion

        public ByteBlock Marshal(ByteBlock byteBlock)
        {
			byteBlock.Write(徒弟编号);
			byteBlock.Write(祝贺等级);
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

