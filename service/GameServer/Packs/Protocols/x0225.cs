#pragma warning disable CS8618

using TouchSocket.Core;
using GameServer.Service;

namespace GameServer.Packs.Protocols
{
    /// <summary>
    /// <para>查看邮件内容</para>
    /// <para>查看邮件内容</para>
    /// </summary>
    internal class x0225 : Package
    {
        #region public

        public int 邮件编号;
        #endregion

        #region marshal


        #endregion

        #region attribute

        public ushort Type => 0x0225;
        public ushort Size => 14;
        public ushort rSize => 0;
        #endregion

        public x0225()
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
            邮件编号 = byteBlock.ReadInt32();
            return byteBlock;
        }

        public void Process(GameSession gameSession)
        {
            throw new NotImplementedException();
        }
    }
}

