using GameServer.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TouchSocket.Core;

namespace GameServer.Packs.Protocols
{
    internal class SyncPrivilegedInfoPacket : Package
    {
        public byte[] Result;

        public ushort Type => 322;

        public ushort Size => 0;

        public SyncPrivilegedInfoPacket()
        {
            Result = new byte[] { 0 };
        }

        public ByteBlock Marshal(ByteBlock byteBlock)
        {
            byteBlock.Write(Result);
            return byteBlock;
        }

        public ByteBlock UnMarshal(ByteBlock byteBlock)
        {
            throw new NotImplementedException();
        }

        public void Process(GameSession gateSession)
        {
            throw new NotImplementedException();
        }
    }
}
