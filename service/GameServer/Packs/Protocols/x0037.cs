#pragma warning disable CS8618

using TouchSocket.Core;
using GameServer.Service;

namespace GameServer.Packs.Protocol
{
    /// <summary>
    /// <para>商店特修单件</para>
    /// <para>商店特修单件</para>
    /// </summary>
    internal class x0037 : Package
    {
        #region public

		public Byte 物品容器;
		public Byte 物品位置;
        #endregion

        #region marshal


        #endregion

        #region attribute

        public ushort Type => 0x0037;
        public ushort Size => 4;     
        public ushort rSize => 0;
        #endregion
        
        public x0037() 
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
			物品容器 = byteBlock.ReadByte();
			物品位置 = byteBlock.ReadByte();
			return byteBlock;
        }

        public void Process(GameSession gameSession)
        {
            throw new NotImplementedException();
        }
    }
}

