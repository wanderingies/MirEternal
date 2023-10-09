using GameServer.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TouchSocket.Core;

namespace GameServer.Packs.Protocols
{
    internal class SyncShortcutbarPacket : Package
    {
        public byte[] Shortcutbar;

        public ushort Type => 19;

        public ushort Size => 0;

        public SyncShortcutbarPacket()
        {
            Shortcutbar = new byte[] { 0 };
        }

        public ByteBlock Marshal(ByteBlock byteBlock)
        {
            byteBlock.Write(Shortcutbar);
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
