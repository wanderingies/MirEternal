#pragma warning disable CS8618

using TouchSocket.Core;
using GameServer.Service;

namespace GameServer.Packs.Protocols
{
    /// <summary>
    /// <para>创建角色</para>
    /// <para>UserCreateRolePacket</para>
    /// </summary>
    internal class x03EA : Package
    {
        #region public

        public string name;
        public byte gender;
        public byte career;
        public byte hairstyle;
        public byte haircolor;
        public byte facestyle;
        #endregion

        #region marshal


        #endregion

        #region attribute

        public ushort Type => 0x03EA;
        public ushort Size => 40;
        public ushort rSize => 0;
        #endregion

        public x03EA()
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
            gender = byteBlock.ReadByte();
            career = byteBlock.ReadByte();
            hairstyle = byteBlock.ReadByte();
            haircolor = byteBlock.ReadByte();
            facestyle = byteBlock.ReadByte();
            return byteBlock;
        }

        public void Process(GameSession gameSession)
        {
            throw new NotImplementedException();
        }
    }
}

