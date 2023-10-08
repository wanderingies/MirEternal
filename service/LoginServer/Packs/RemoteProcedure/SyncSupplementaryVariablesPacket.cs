using LoginServer.Service;
using TouchSocket.Core;

namespace LoginServer.Packs.RemoteProcedure
{
    internal class SyncSupplementaryVariablesPacket : Package
    {
        public byte VariableType;
        public ushort VariableIndex;
        public int VariableObject;
        public int VariableValue;


        public ushort Type => 187;
        public ushort Size => 13;

        public ByteBlock Marshal(ByteBlock byteBlock)
        {
            byteBlock.Write(VariableType);
            byteBlock.Write(VariableIndex);
            byteBlock.Write(VariableObject);
            byteBlock.Write(VariableValue);
            return byteBlock;
        }        

        public ByteBlock UnMarshal(ByteBlock byteBlock)
        {
            throw new NotImplementedException();
        }

        public void Process(LoginSession gateSession)
        {
            throw new NotImplementedException();
        }
    }
}
