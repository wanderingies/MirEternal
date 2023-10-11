#pragma warning disable CS8618

using TouchSocket.Core;
using WorldServer.Service;

namespace WorldServer.Packs.Protocol
{
    /// <summary>
    /// <para>拾取金币</para>
    /// <para>玩家拾取金币</para>
    /// </summary>
    internal class x0088 : Package
    {
        #region public field

		public Int32 NumberGoldCoins;
        #endregion

        #region public attribute

        public ushort Type => 0x0088;
        public ushort Size => 10;        
        #endregion
        
        #region private field


        #endregion

        public ByteBlock Marshal(ByteBlock byteBlock)
        {
			byteBlock.Write(NumberGoldCoins);
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

