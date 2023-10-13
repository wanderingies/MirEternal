#pragma warning disable CS8618

using TouchSocket.Core;
using GameServer.Service;

namespace GameServer.Packs.Protocols
{
    /// <summary>
    /// <para>不知道干嘛的, 离开进入安全区触发</para>
    /// <para>ReservedPacketZeroTwoPacket</para>
    /// </summary>
    internal class x00BB : Package
    {
        #region public

        #endregion

        #region marshal

        public byte VariableType;
        public ushort VariableIndex;
        public int VariableKey;
        public int VariableValue;
        #endregion

        #region attribute

        public ushort Type => 0x00BB;
        public ushort Size => 9;
        public ushort rSize => 13;
        #endregion

        public x00BB()
        {
        }

        #region private


        #endregion

        public ByteBlock Marshal(ByteBlock byteBlock)
        {
            byteBlock.Write(VariableType);
            byteBlock.Write(VariableIndex);
            byteBlock.Write(VariableKey);
            byteBlock.Write(VariableValue);
            return byteBlock;
        }

        public ByteBlock UnMarshal(ByteBlock byteBlock)
        {
            return byteBlock;
        }

        public void Process(GameSession gameSession)
        {
            Program.service.Logger.Warning("0x00BB => The method or operation is not implemented.");
        }
    }
}

