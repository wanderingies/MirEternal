#pragma warning disable CS8618

using TouchSocket.Core;
using GameServer.Service;

namespace GameServer.Packs.Protocol
{
    /// <summary>
    /// <para>Received on player connects (ver. 1.0.3.68 / 185578)</para>
    /// <para>PlayerEnterScenePacket</para>
    /// </summary>
    internal class x010F : Package
    {
        #region public field

        #endregion

        #region public attribute

        public ushort Type => 0x010F;
        public ushort Size => 2;        
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

        public void Process(GameSession session)
        {
            
        }
    }
}

