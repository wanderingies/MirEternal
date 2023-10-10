#pragma warning disable CS0649

using GameServer.Service;
using TouchSocket.Core;

namespace GameServer.Packs.Protocols
{
    internal class SyncCheckinPacket : Package
    {
        public bool ischeckin;
        public byte checkincount;

        public ushort Type => 288;

        public ushort Size => 5;

        public ByteBlock Marshal(ByteBlock byteBlock)
        {
            byteBlock.Write(ischeckin);
            byteBlock.Write(checkincount);
            byteBlock.Write(new byte[] { 0 });
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
