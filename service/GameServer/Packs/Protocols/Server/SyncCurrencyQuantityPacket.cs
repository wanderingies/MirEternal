using GameServer.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TouchSocket.Core;

namespace GameServer.Packs.Protocols
{
    internal class SyncCurrencyQuantityPacket : Package
    {
        public byte[] Result;

        public ushort Type => 148;

        public ushort Size => 0;

        public SyncCurrencyQuantityPacket()
        {
            Result = new byte[] { 1, 1, 1, 1, 0, 0, 1 };
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
