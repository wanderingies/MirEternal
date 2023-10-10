using GateServer.Packs.Protocols;
using TouchSocket.Core;

namespace GateServer.Packs
{
    internal class PackageAdapter : CustomDataHandlingAdapter<PackageRequest>
    {
        public byte EncryptionKey = 129;    
        
        public byte[] EncryptionValue(byte[] value)
        {
            for (int i = 4; i < value.Length; i++)
                value[i] ^= EncryptionKey;

            return value;
        }

        public ByteBlock EncryptionValue(ByteBlock byteBlock)
        {
            ByteBlock result = new ByteBlock(byteBlock.Len);
            for (int i = 4; i < byteBlock.Len; i++)
                result.Write(byteBlock.Buffer[i] ^ EncryptionKey);

            return result;
        }

        protected override FilterResult Filter(in ByteBlock byteBlock, bool beCached, ref PackageRequest request, ref int tempCapacity)
        {
            if (byteBlock.CanReadLen < 4)
                return FilterResult.Cache;

            byteBlock.Begin();
            ushort pId = byteBlock.ReadUInt16();
            byteBlock.Rollback();

            request = new PackageRequest();
            if (LoginProtocols.Instance.TryGetValue(pId, out _))
            {
                byteBlock.Begin();
                request.Type = pId;
                byteBlock.Read(out byte[] buffer, byteBlock.Len);
                request.Buffer = EncryptionValue(buffer);
                byteBlock.Commit();

                return FilterResult.Success;
            }

            if(WorldProtocols.Instance.TryGetValue(pId, out _))
            {
                byteBlock.Begin();
                request.Type = pId;
                byteBlock.Read(out byte[] buffer, byteBlock.Len);
                request.Buffer = EncryptionValue(buffer);
                byteBlock.Commit();

                return FilterResult.Success;
            }

            Program.service.Logger.Error($"{pId} => 未知封包");
            return FilterResult.Success;
        }
    }
}
