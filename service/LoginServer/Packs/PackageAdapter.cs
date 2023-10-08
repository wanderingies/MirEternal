using TouchSocket.Core;

namespace LoginServer.Packs
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
            //byteBlock.Commit();
            byteBlock.Rollback();

            request = new PackageRequest();
            if (Package.AllPackage.ContainsKey(pId)/* || Package.AllPackage[pId].Size == byteBlock.Len*/)
            {
                //byteBlock.Begin();
                request.Type = byteBlock.ReadUInt16();
                //byteBlock.Commit();

                byte[] buffer = new byte[byteBlock.Len];
                byteBlock.Read(buffer, 0, byteBlock.Len);
                request.ByteBlock = new ByteBlock(buffer);

                return FilterResult.Success;
            }
            
            return FilterResult.Cache;
        }
    }
}
