using LoginServer.Service;
using LoginServer.Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TouchSocket.Core;

namespace LoginServer.Packs.Protocols
{
    internal class x03F2 : Package
    {
        public int Synchronisedtime;

        public ushort Type => 0x03F2;

        public ushort Size => 6;

        public ByteBlock Marshal(ByteBlock byteBlock)
        {
            byteBlock.Write(UtilityLibrary.TimeShift(DateTime.Now));
            return byteBlock;
        }

        public void Process(LoginSession gateSession)
        {
            throw new NotImplementedException();
        }

        public ByteBlock UnMarshal(ByteBlock byteBlock)
        {
            throw new NotImplementedException();
        }
    }
}
