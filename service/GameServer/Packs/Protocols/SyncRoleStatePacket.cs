using GameServer.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TouchSocket.Core;

namespace GameServer.Packs.Protocols
{
    internal class SyncRoleStatePacket : Package
    {
        public byte[] State;

        public ushort Type => 14;

        public ushort Size => 0;

        public SyncRoleStatePacket()
        {
            State = new byte[] { 0 };
        }

        public ByteBlock Marshal(ByteBlock byteBlock)
        {
            byteBlock.Write(State);
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
