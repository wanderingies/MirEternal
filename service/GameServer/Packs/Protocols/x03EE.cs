#pragma warning disable CS8618

using TouchSocket.Core;
using GameServer.Service;

namespace GameServer.Packs.Protocol
{
    /// <summary>
    /// <para>进入游戏</para>
    /// <para>UserEnterPacket</para>
    /// </summary>
    internal class x03EE : Package
    {
        #region public

		public Int32 roleid;
        #endregion

        #region marshal


        #endregion

        #region attribute

        public ushort Type => 0x03EE;
        public ushort Size => 6;     
        public ushort rSize => 0;
        #endregion
        
        public x03EE() 
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

