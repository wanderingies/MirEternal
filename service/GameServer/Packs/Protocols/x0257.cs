#pragma warning disable CS8618

using TouchSocket.Core;
using GameServer.Service;

namespace GameServer.Packs.Protocol
{
    /// <summary>
    /// <para>RequestTreasureDataPacket</para>
    /// <para>RequestTreasureDataPacket</para>
    /// </summary>
    internal class x0257 : Package
    {
        #region public field

		public Int32 数据版本;
        #endregion

        #region public attribute

        public ushort Type => 0x0257;
        public ushort Size => 6;        
        #endregion
        
        #region private field


        #endregion

        public ByteBlock Marshal(ByteBlock byteBlock)
        {
            return byteBlock;
        }

        public ByteBlock UnMarshal(ByteBlock byteBlock)
        {
			数据版本 = byteBlock.ReadInt32();
            return byteBlock;
        }

        public void Process(GameSession session)
        {
            
        }
    }
}

