#pragma warning disable CS8618

using TouchSocket.Core;
using GameServer.Service;

namespace GameServer.Packs.Protocols
{
    /// <summary>
    /// <para>RequestStoreDataPacket</para>
    /// <para>RequestStoreDataPacket</para>
    /// </summary>
    internal class x0041 : Package
    {
        #region public

        public int 版本编号;
        #endregion

        #region marshal


        #endregion

        #region attribute

        public ushort Type => 0x0041;
        public ushort Size => 6;
        public ushort rSize => 0;
        #endregion

        public x0041()
        {
        }

        #region private


        #endregion

        public ByteBlock Marshal(ByteBlock byteBlock)
        {
            throw new NotImplementedException();
        }

        public ByteBlock UnMarshal(ByteBlock byteBlock)
        {
            版本编号 = byteBlock.ReadInt32();
            return byteBlock;
        }

        public void Process(GameSession gameSession)
        {
            throw new NotImplementedException();
        }
    }
}

