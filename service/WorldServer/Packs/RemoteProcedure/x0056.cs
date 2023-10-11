#pragma warning disable CS8618

using TouchSocket.Core;
using WorldServer.Service;

namespace WorldServer.Packs.Protocol
{
    /// <summary>
    /// <para>同步战力</para>
    /// <para>SyncPlayerPowerPacket</para>
    /// </summary>
    internal class x0056 : Package
    {
        #region public field

		public Int32 角色编号;
		public Int32 角色战力;
        #endregion

        #region public attribute

        public ushort Type => 0x0056;
        public ushort Size => 10;        
        #endregion
        
        #region private field


        #endregion

        public ByteBlock Marshal(ByteBlock byteBlock)
        {
			byteBlock.Write(角色编号);
			byteBlock.Write(角色战力);
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

