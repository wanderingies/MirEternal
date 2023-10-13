#pragma warning disable CS8618

using TouchSocket.Core;
using GameServer.Service;

namespace GameServer.Packs.Protocol
{
    /// <summary>
    /// <para>更换角色</para>
    /// <para>客户更换角色</para>
    /// </summary>
    internal class x000A : Package
    {
        #region public

		public Int32 编号;
        #endregion

        #region marshal


        #endregion

        #region attribute

        public ushort Type => 0x000A;
        public ushort Size => 6;     
        public ushort rSize => 0;
        #endregion
        
        public x000A() 
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
			编号 = byteBlock.ReadInt32();
			return byteBlock;
        }

        public void Process(GameSession gameSession)
        {
            throw new NotImplementedException();
        }
    }
}

