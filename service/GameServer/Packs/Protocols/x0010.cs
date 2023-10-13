#pragma warning disable CS8618

using TouchSocket.Core;
using GameServer.Service;

namespace GameServer.Packs.Protocols
{
    /// <summary>
    /// <para>角色转动</para>
    /// <para>客户角色转动</para>
    /// </summary>
    internal class x0010 : Package
    {
        #region public

        public short RotationDir;
        public uint RotationTime;
        #endregion

        #region marshal


        #endregion

        #region attribute

        public ushort Type => 0x0010;
        public ushort Size => 8;
        public ushort rSize => 0;
        #endregion

        public x0010()
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
            RotationDir = byteBlock.ReadInt16();
            RotationTime = byteBlock.ReadUInt32();
            return byteBlock;
        }

        public void Process(GameSession gameSession)
        {
            Program.service.Logger.Warning("0x0010 => 角色转动(已接收单处理)");
        }
    }
}

