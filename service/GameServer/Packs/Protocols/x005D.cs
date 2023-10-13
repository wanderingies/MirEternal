#pragma warning disable CS8618

using TouchSocket.Core;
using GameServer.Service;

namespace GameServer.Packs.Protocol
{
    /// <summary>
    /// <para>随身修理单件</para>
    /// <para>随身修理单件</para>
    /// </summary>
    internal class x005D : Package
    {
        #region public

		public Byte 物品容器;
		public Byte 物品位置;
		public Int32 Id;
        #endregion

        #region marshal


        #endregion

        #region attribute

        public ushort Type => 0x005D;
        public ushort Size => 8;     
        public ushort rSize => 0;
        #endregion
        
        public x005D() 
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
			Id = byteBlock.ReadInt32();
			return byteBlock;
        }

        public void Process(GameSession gameSession)
        {
            throw new NotImplementedException();
        }
    }
}

