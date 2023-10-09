using GameServer.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TouchSocket.Core;

namespace GameServer.Packs.Protocols
{
    internal class SyncSkillInfoPacket : Package
    {
        public byte[] SkillInfo;

        public ushort Type => 18;

        public ushort Size => 0;

        public SyncSkillInfoPacket()
        {
            SkillInfo = new byte[] { 0 };
        }

        public ByteBlock Marshal(ByteBlock byteBlock)
        {            
            byteBlock.Write(SkillInfo);
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
