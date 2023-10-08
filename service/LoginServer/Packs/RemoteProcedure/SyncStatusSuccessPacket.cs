using LoginServer.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TouchSocket.Core;

namespace LoginServer.Packs.RemoteProcedure
{
    /// <summary>
    /// 同步服务状态
    /// </summary>
    internal class SyncStatusSuccessPacket : Package
    {
        public ushort Type => 1012;

        public ushort Size => 3;

        public ByteBlock Marshal(ByteBlock byteBlock)
        {
            byteBlock.Write(new byte[] { 0 });
            return byteBlock;
        }        

        public ByteBlock UnMarshal(ByteBlock byteBlock)
        {
            return byteBlock;
        }

        public void Process(LoginSession gateSession)
        {
            
        }
    }
}
