#pragma warning disable CS8618

using TouchSocket.Core;
using WorldServer.Service;

namespace WorldServer.Packs.Protocol
{
    /// <summary>
    /// <para>SyncMarfaPrivilegesPacket</para>
    /// <para>SyncMarfaPrivilegesPacket</para>
    /// </summary>
    internal class x014C : Package
    {
        #region public field

		public Byte 玛法特权;
        #endregion

        #region public attribute

        public ushort Type => 0x014C;
        public ushort Size => 3;        
        #endregion
        
        #region private field


        #endregion

        public ByteBlock Marshal(ByteBlock byteBlock)
        {
			byteBlock.Write(玛法特权);
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

