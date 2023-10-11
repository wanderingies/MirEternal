using GameServer.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TouchSocket.Core;

namespace GameServer.Packs.Protocols
{
    internal class x00BA : Package
    {
        public byte[] Result;

        public ushort Type => 0x00BA;

        public ushort Size => 514;

        public x00BA()
        {
            Result = new byte[511];
        }

        public ByteBlock Marshal(ByteBlock byteBlock)
        {
            byteBlock.Write(Result);
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
