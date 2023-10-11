#pragma warning disable CS8618

using TouchSocket.Core;
using WorldServer.Service;

namespace WorldServer.Packs.Protocol
{
    /// <summary>
    /// <para>PutInUpgradedWeaponPacket</para>
    /// <para>PutInUpgradedWeaponPacket</para>
    /// </summary>
    internal class x0100 : Package
    {
        #region public field

        #endregion

        #region public attribute

        public ushort Type => 0x0100;
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

        public void Process(WorldSession session)
        {
            
        }
    }
}

