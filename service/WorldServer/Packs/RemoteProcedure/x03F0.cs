#pragma warning disable CS8618

using TouchSocket.Core;
using WorldServer.Service;

namespace WorldServer.Packs.Protocol
{
    /// <summary>
    /// <para>DeleteCharacterPacket回应</para>
    /// <para>DeleteCharacterPacket</para>
    /// </summary>
    internal class x03F0 : Package
    {
        #region public field

		public Int32 角色编号;
        #endregion

        #region public attribute

        public ushort Type => 0x03F0;
        public ushort Size => 6;        
        #endregion
        
        #region private field


        #endregion

        public ByteBlock Marshal(ByteBlock byteBlock)
        {
			byteBlock.Write(角色编号);
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

