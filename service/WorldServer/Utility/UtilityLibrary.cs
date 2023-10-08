using TouchSocket.Core;

namespace WorldServer.Utility
{
    internal class UtilityLibrary
    {
        public static byte EncryptionKey = 129;

        public static byte[] EncryptionValue(byte[] data)
        {
            for (int i = 2; i < data.Length; i++)
                data[i] ^= EncryptionKey;

            return data;
        }

        public static byte[] EncryptionValue(byte[] data, int length)
        {
            for (int i = 4; i < length; i++)
                data[i] ^= EncryptionKey;

            return data;
        }

        public static ByteBlock EncryptionValue(ByteBlock byteBlock)
        {
            ByteBlock result = new ByteBlock(byteBlock.Len);
            for (int i = 4; i < byteBlock.Len; i++)
                result.Write(byteBlock.Buffer[i] ^ EncryptionKey);

            return result;
        }
    }
}
