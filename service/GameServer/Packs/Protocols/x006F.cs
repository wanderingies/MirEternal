#pragma warning disable CS8618

using TouchSocket.Core;
using GameServer.Service;

namespace GameServer.Packs.Protocols
{
    /// <summary>
    /// <para>打开角色摊位</para>
    /// <para>打开角色摊位</para>
    /// </summary>
    internal class x006F : Package
    {
        #region public

        public int 对象编号;
        #endregion

        #region marshal


        #endregion

        #region attribute

        public ushort Type => 0x006F;
        public ushort Size => 6;
        public ushort rSize => 0;
        #endregion

        public x006F()
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
            对象编号 = byteBlock.ReadInt32();
            return byteBlock;
        }

        public void Process(GameSession gameSession)
        {
            throw new NotImplementedException();
        }
    }
}

