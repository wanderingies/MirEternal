#pragma warning disable CS8618

using TouchSocket.Core;
using GameServer.Service;

namespace GameServer.Packs.Protocol
{
    /// <summary>
    /// <para>取消好友关注</para>
    /// <para>取消好友关注</para>
    /// </summary>
    internal class x020B : Package
    {
        #region public

		public Int32 对象编号;
        #endregion

        #region marshal


        #endregion

        #region attribute

        public ushort Type => 0x020B;
        public ushort Size => 6;     
        public ushort rSize => 0;
        #endregion
        
        public x020B() 
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
			对象编号 = byteBlock.ReadInt32();
			return byteBlock;
        }

        public void Process(GameSession gameSession)
        {
            throw new NotImplementedException();
        }
    }
}

