#pragma warning disable CS8618

using TouchSocket.Core;
using GameServer.Service;

namespace GameServer.Packs.Protocol
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

        public Byte VariableType;
        public UInt16 VariableIndex;
        public Int32 VariableKey;
        public Int32 VariableValue;
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
			throw new NotImplementedException();
        }

        public void Process(GameSession gameSession)
        {
            throw new NotImplementedException();
        }
    }
}

