using GameServer.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TouchSocket.Core;

namespace GameServer.Packs.Protocols
{
    internal class SyncBackpackInfoPacket : Package
    {
        public byte[] Backpack;

        public ushort Type => 17;

        public ushort Size => 0;

        public SyncBackpackInfoPacket()
        {
            Backpack = new byte[] { 0 };
        }

        public ByteBlock Marshal(ByteBlock byteBlock)
        {
            byteBlock.Write(Backpack);
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
