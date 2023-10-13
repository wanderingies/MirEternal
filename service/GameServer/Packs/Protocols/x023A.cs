#pragma warning disable CS8618

using TouchSocket.Core;
using GameServer.Service;

namespace GameServer.Packs.Protocols
{
    /// <summary>
    /// <para>处理结盟申请</para>
    /// <para>处理结盟申请</para>
    /// </summary>
    internal class x023A : Package
    {
        #region public

        public byte 处理类型;
        public int 行会编号;
        #endregion

        #region marshal


        #endregion

        #region attribute

        public ushort Type => 0x023A;
        public ushort Size => 7;
        public ushort rSize => 0;
        #endregion

        public x023A()
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
            处理类型 = byteBlock.ReadByte();
            行会编号 = byteBlock.ReadInt32();
            return byteBlock;
        }

        public void Process(GameSession gameSession)
        {
            throw new NotImplementedException();
        }
    }
}

