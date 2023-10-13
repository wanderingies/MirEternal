#pragma warning disable CS8618

using TouchSocket.Core;
using GameServer.Service;

namespace GameServer.Packs.Protocols
{
    /// <summary>
    /// <para>提取邮件附件</para>
    /// <para>提取邮件附件</para>
    /// </summary>
    internal class x0227 : Package
    {
        #region public

        public int 邮件编号;
        #endregion

        #region marshal


        #endregion

        #region attribute

        public ushort Type => 0x0227;
        public ushort Size => 14;
        public ushort rSize => 0;
        #endregion

        public x0227()
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

