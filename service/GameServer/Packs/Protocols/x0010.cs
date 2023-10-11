#pragma warning disable CS8618

using TouchSocket.Core;
using GameServer.Service;

namespace GameServer.Packs.Protocol
{
    /// <summary>
    /// <para>角色转动</para>
    /// <para>客户角色转动</para>
    /// </summary>
    internal class x0010 : Package
    {
        #region public field

		public Int16 转动方向;
		public UInt32 转动耗时;
        #endregion

        #region public attribute

        public ushort Type => 0x0010;
        public ushort Size => 8;        
        #endregion
        
        #region private field


        #endregion

        public ByteBlock Marshal(ByteBlock byteBlock)
        {
            return byteBlock;
        }

        public ByteBlock UnMarshal(ByteBlock byteBlock)
        {
			转动方向 = byteBlock.ReadInt16();
			转动耗时 = byteBlock.ReadUInt32();
            return byteBlock;
        }

        public void Process(GameSession session)
        {
            
        }
    }
}

