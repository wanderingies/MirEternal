#pragma warning disable CS8618

using TouchSocket.Core;
using GameServer.Service;

namespace GameServer.Packs.Protocol
{
    /// <summary>
    /// <para>申请解除结盟</para>
    /// <para>申请解除结盟</para>
    /// </summary>
    internal class x023B : Package
    {
        #region public

		public Int32 行会编号;
        #endregion

        #region marshal


        #endregion

        #region attribute

        public ushort Type => 0x023B;
        public ushort Size => 6;     
        public ushort rSize => 0;
        #endregion
        
        public x023B() 
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
			行会编号 = byteBlock.ReadInt32();
			return byteBlock;
        }

        public void Process(GameSession gameSession)
        {
            throw new NotImplementedException();
        }
    }
}

