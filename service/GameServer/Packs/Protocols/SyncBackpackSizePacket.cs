#pragma warning disable CS0649

using GameServer.Service;
using TouchSocket.Core;

namespace GameServer.Packs.Protocols
{
    internal class SyncBackpackSizePacket : Package
    {
        public byte PackSize;
        public byte BackpackSize;
        public byte WarehouseSize;
        public byte u1;
        public byte u2;
        public byte u3;
        public byte u4;
        public byte ExtraBackpackSize;
        public byte u5;

        public ushort Type => 15;

        public ushort Size => 11;

        public ByteBlock Marshal(ByteBlock byteBlock)
        {
            byteBlock.Write(PackSize);
            byteBlock.Write(BackpackSize);
            byteBlock.Write(WarehouseSize);
            byteBlock.Write(u1);
            byteBlock.Write(u2);
            byteBlock.Write(u3);
            byteBlock.Write(u4);
            byteBlock.Write(ExtraBackpackSize);
            byteBlock.Write(u5);
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
