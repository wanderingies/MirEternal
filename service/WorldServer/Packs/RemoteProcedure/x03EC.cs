#pragma warning disable CS8618

using TouchSocket.Core;
using WorldServer.Service;

namespace WorldServer.Packs.Protocol
{
    /// <summary>
    /// <para>同步角色列表</para>
    /// <para>BackCharacterListPacket</para>
    /// </summary>
    internal class x03EC : Package
    {
        #region public field

        #endregion

        #region public attribute

        public ushort Type => 0x03EC;
        public ushort Size => 849;        
        #endregion
        
        #region private field


        #endregion

        public ByteBlock Marshal(ByteBlock byteBlock)
        {
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

