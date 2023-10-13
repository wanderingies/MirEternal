#pragma warning disable CS8618

using TouchSocket.Core;
using GameServer.Service;

namespace GameServer.Packs.Protocol
{
    /// <summary>
    /// <para>添加仇人</para>
    /// <para>玩家添加仇人</para>
    /// </summary>
    internal class x020F : Package
    {
        #region public

		public Int32 对象编号;
        #endregion

        #region marshal


        #endregion

        #region attribute

        public ushort Type => 0x020F;
        public ushort Size => 6;     
        public ushort rSize => 0;
        #endregion
        
        public x020F() 
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

