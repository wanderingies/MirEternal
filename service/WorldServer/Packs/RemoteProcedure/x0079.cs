#pragma warning disable CS8618

using TouchSocket.Core;
using WorldServer.Service;

namespace WorldServer.Packs.Protocol
{
    /// <summary>
    /// <para>CharacterSelectionTargetPacket</para>
    /// <para>玩家选中目标</para>
    /// </summary>
    internal class x0079 : Package
    {
        #region public field

		public Int32 角色编号;
		public Int32 目标编号;
        #endregion

        #region public attribute

        public ushort Type => 0x0079;
        public ushort Size => 10;        
        #endregion
        
        #region private field


        #endregion

        public ByteBlock Marshal(ByteBlock byteBlock)
        {
			byteBlock.Write(角色编号);
			byteBlock.Write(目标编号);
            return byteBlock;
        }

        public ByteBlock UnMarshal(ByteBlock byteBlock)
        {
            return byteBlock;
        }

        public void Process(WorldSession session)
        {
            
        }
    }
}

