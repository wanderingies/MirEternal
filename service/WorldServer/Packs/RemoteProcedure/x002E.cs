#pragma warning disable CS8618

using TouchSocket.Core;
using WorldServer.Service;

namespace WorldServer.Packs.Protocol
{
    /// <summary>
    /// <para>角色走动</para>
    /// <para>ObjectCharacterWalkPacket</para>
    /// </summary>
    internal class x002E : Package
    {
        #region public field

		public Int32 对象编号;
		public UInt16 移动速度;
        #endregion

        #region public attribute

        public ushort Type => 0x002E;
        public ushort Size => 12;        
        #endregion
        
        #region private field


        #endregion

        public ByteBlock Marshal(ByteBlock byteBlock)
        {
			byteBlock.Write(对象编号);
			byteBlock.Write(移动速度);
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

