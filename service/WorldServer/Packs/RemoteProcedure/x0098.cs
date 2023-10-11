#pragma warning disable CS8618

using TouchSocket.Core;
using WorldServer.Service;

namespace WorldServer.Packs.Protocol
{
    /// <summary>
    /// <para>GamePropsAppearPacket</para>
    /// <para>GamePropsAppearPacket</para>
    /// </summary>
    internal class x0098 : Package
    {
        #region public field

        #endregion

        #region public attribute

        public ushort Type => 0x0098;
        public ushort Size => 19;        
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

