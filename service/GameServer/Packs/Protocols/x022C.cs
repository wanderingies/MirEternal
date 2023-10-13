#pragma warning disable CS8618

using TouchSocket.Core;
using GameServer.Service;

namespace GameServer.Packs.Protocols
{
    /// <summary>
    /// <para>申请加入行会</para>
    /// <para>申请加入行会</para>
    /// </summary>
    internal class x022C : Package
    {
        #region public

        public int 行会编号;
        public string GuildName;
        #endregion

        #region marshal


        #endregion

        #region attribute

        public ushort Type => 0x022C;
        public ushort Size => 31;
        public ushort rSize => 0;
        #endregion

        public x022C()
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
            行会编号 = byteBlock.ReadInt32();
            return byteBlock;
        }

        public void Process(GameSession gameSession)
        {
            throw new NotImplementedException();
        }
    }
}

