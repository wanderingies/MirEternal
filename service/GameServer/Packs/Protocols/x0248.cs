#pragma warning disable CS8618

using TouchSocket.Core;
using GameServer.Service;

namespace GameServer.Packs.Protocols
{
    /// <summary>
    /// <para>申请行会Hostility</para>
    /// <para>申请行会Hostility</para>
    /// </summary>
    internal class x0248 : Package
    {
        #region public

        public byte Hostility时间;
        public string GuildName;
        #endregion

        #region marshal


        #endregion

        #region attribute

        public ushort Type => 0x0248;
        public ushort Size => 28;
        public ushort rSize => 0;
        #endregion

        public x0248()
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
            Hostility时间 = byteBlock.ReadByte();
            return byteBlock;
        }

        public void Process(GameSession gameSession)
        {
            throw new NotImplementedException();
        }
    }
}

