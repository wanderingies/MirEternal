#pragma warning disable CS8618

using TouchSocket.Core;
using GameServer.Service;

namespace GameServer.Packs.Protocol
{
    /// <summary>
    /// <para>RequestStoreDataPacket</para>
    /// <para>RequestStoreDataPacket</para>
    /// </summary>
    internal class x0041 : Package
    {
        #region public field

		public Int32 版本编号;
        #endregion

        #region public attribute

        public ushort Type => 0x0041;
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
			版本编号 = byteBlock.ReadInt32();
            return byteBlock;
        }

        public void Process(GameSession session)
        {
            
        }
    }
}

