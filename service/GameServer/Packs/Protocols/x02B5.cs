using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TouchSocket.Core;
using GameServer.Service;

namespace GameServer.Packs.RemoteProcedure
{
    internal class x02B5 : Package
    {
        public int unkown;

        public ushort Type => 0x02B5;

        public ushort Size => 6;

        public ByteBlock Marshal(ByteBlock byteBlock)
        {
            byteBlock.Write(unkown);
            return byteBlock;
        }        

        public ByteBlock UnMarshal(ByteBlock byteBlock)
        {
            return byteBlock;
        }

        public void Process(GameSession gateSession)
        {
            
        }
    }
}
