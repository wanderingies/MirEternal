#pragma warning disable CS8618

using TouchSocket.Core;
using GameServer.Service;

namespace GameServer.Packs.Protocol
{
    /// <summary>
    /// <para>SyncPrivilegedInfoPacket</para>
    /// <para>SyncPrivilegedInfoPacket</para>
    /// </summary>
    internal class x0142 : Package
    {
        #region public field

        public byte[] Result;
        #endregion

        #region public attribute

        public ushort Type => 0x0142;
        public ushort Size => 0;        
        #endregion

        public x0142()
        {
            Result = new byte[] { 0 };
        }
        
        #region private field


        #endregion

        public ByteBlock Marshal(ByteBlock byteBlock)
        {
            byteBlock.Write(Result);
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

