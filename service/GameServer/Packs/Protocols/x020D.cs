#pragma warning disable CS8618

using TouchSocket.Core;
using GameServer.Service;

namespace GameServer.Packs.Protocols
{
    /// <summary>
    /// <para>上传社交信息(已屏蔽)</para>
    /// <para>上传社交信息</para>
    /// </summary>
    internal class x020D : Package
    {
        #region public

        #endregion

        #region marshal

        #endregion

        #region attribute

        public ushort Type => 0x020D;
        public ushort Size => 40;
        public ushort rSize => 0;
        #endregion

        public x020D()
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
            return byteBlock;
        }

        public void Process(GameSession gameSession)
        {
            Program.service.Logger.Warning($"0x020D => The method or operation is not implemented.");
        }
    }
}

