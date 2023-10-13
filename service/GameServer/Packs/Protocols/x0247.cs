#pragma warning disable CS8618

using TouchSocket.Core;
using GameServer.Service;

namespace GameServer.Packs.Protocols
{
    /// <summary>
    /// <para>处理解敌申请</para>
    /// <para>处理解敌申请</para>
    /// </summary>
    internal class x0247 : Package
    {
        #region public

        public byte 回应类型;
        public int 行会编号;
        #endregion

        #region marshal


        #endregion

        #region attribute

        public ushort Type => 0x0247;
        public ushort Size => 7;
        public ushort rSize => 0;
        #endregion

        public x0247()
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
            回应类型 = byteBlock.ReadByte();
            行会编号 = byteBlock.ReadInt32();
            return byteBlock;
        }

        public void Process(GameSession gameSession)
        {
            throw new NotImplementedException();
        }
    }
}

