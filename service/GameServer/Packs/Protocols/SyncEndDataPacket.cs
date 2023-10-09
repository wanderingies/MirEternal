using GameServer.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TouchSocket.Core;

namespace GameServer.Packs.Protocols
{
    internal class SyncEndDataPacket : Package
    {
        public int roleid;

        public ushort Type => 33;

        public ushort Size => 6;

        public ByteBlock Marshal(ByteBlock byteBlock)
        {
            byteBlock.Write(roleid);
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
