#pragma warning disable CS8618

using TouchSocket.Core;
using GameServer.Service;

namespace GameServer.Packs.Protocol
{
    /// <summary>
    /// <para>查看行会列表</para>
    /// <para>查看行会列表</para>
    /// </summary>
    internal class x0229 : Package
    {
        #region public field

		public Byte 查看方式;
		public Int32 行会编号;
        #endregion

        #region public attribute

        public ushort Type => 0x0229;
        public ushort Size => 7;        
        #endregion
        
        #region private field


        #endregion

        public ByteBlock Marshal(ByteBlock byteBlock)
        {
            return byteBlock;
        }

        public ByteBlock UnMarshal(ByteBlock byteBlock)
        {
			查看方式 = byteBlock.ReadByte();
			行会编号 = byteBlock.ReadInt32();
            return byteBlock;
        }

        public void Process(GameSession session)
        {
            
        }
    }
}

