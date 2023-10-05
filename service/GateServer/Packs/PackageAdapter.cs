using TouchSocket.Core;

namespace GateServer.Packs
{
    internal class PackageAdapter : CustomDataHandlingAdapter<PackageRequest>
    {
        public byte EncryptionKey;

        public byte[] EncryptionValue(byte[] data)
        {
            for (int i = 4; i < data.Length; i++)
                data[i] ^= EncryptionKey;

            return data;
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
            byteBlock.Commit();

            if (Package.AllPackage.ContainsKey(pId) || Package.AllPackage[pId].Size == byteBlock.Len)
            {
                request.Type = pId;
                if (pId != 1001)
                    request.ByteBlock = EncryptionValue(byteBlock);
                else request.ByteBlock = byteBlock;

                return FilterResult.Success;
            }

            byteBlock.Insert(0, BitConverter.GetBytes(pId));
            return FilterResult.Cache;
        }
    }
}
