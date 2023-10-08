using TouchSocket.Core;

namespace GateServer.Utility
{
    internal class UtilityLibrary
    {
        public static byte EncryptionKey = 129;

        public static byte[] EncryptionValue(byte[] data)
        {
            for (int i = 4; i < data.Length; i++)
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
