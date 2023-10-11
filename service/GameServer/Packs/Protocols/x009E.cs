#pragma warning disable CS8618

using TouchSocket.Core;
using GameServer.Service;

namespace GameServer.Packs.Protocol
{
    /// <summary>
    /// <para>更改收徒推送</para>
    /// <para>更改收徒推送</para>
    /// </summary>
    internal class x009E : Package
    {
        #region public field

		public Boolean 收徒推送;
        #endregion

        #region public attribute

        public ushort Type => 0x009E;
        public ushort Size => 3;        
        #endregion
        
        #region private field


        #endregion

        public ByteBlock Marshal(ByteBlock byteBlock)
        {
            return byteBlock;
        }

        public ByteBlock UnMarshal(ByteBlock byteBlock)
        {
			收徒推送 = byteBlock.ReadBoolean();
            return byteBlock;
        }

        public void Process(GameSession session)
        {
            
        }
    }
}

