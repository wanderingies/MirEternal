#pragma warning disable CS8618

using TouchSocket.Core;
using GameServer.Service;

namespace GameServer.Packs.Protocol
{
    /// <summary>
    /// <para>找回冻结的角色</para>
    /// <para>UserBackRolePacket</para>
    /// </summary>
    internal class x03ED : Package
    {
        #region public

		public Int32 roleid;
        #endregion

        #region marshal


        #endregion

        #region attribute

        public ushort Type => 0x03ED;
        public ushort Size => 6;     
        public ushort rSize => 0;
        #endregion
        
        public x03ED() 
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
			roleid = byteBlock.ReadInt32();
			return byteBlock;
        }

        public void Process(GameSession gameSession)
        {
            throw new NotImplementedException();
        }
    }
}

