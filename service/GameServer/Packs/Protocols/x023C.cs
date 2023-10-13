#pragma warning disable CS8618

using TouchSocket.Core;
using GameServer.Service;

namespace GameServer.Packs.Protocols
{
    /// <summary>
    /// <para>更改存储权限</para>
    /// <para>更改存储权限</para>
    /// </summary>
    internal class x023C : Package
    {
        #region public

        public byte GuildJobs;
        public byte 原有位置;
        public byte 目标页面;
        #endregion

        #region marshal


        #endregion

        #region attribute

        public ushort Type => 0x023C;
        public ushort Size => 5;
        public ushort rSize => 0;
        #endregion

        public x023C()
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
            GuildJobs = byteBlock.ReadByte();
            原有位置 = byteBlock.ReadByte();
            目标页面 = byteBlock.ReadByte();
            return byteBlock;
        }

        public void Process(GameSession gameSession)
        {
            throw new NotImplementedException();
        }
    }
}

