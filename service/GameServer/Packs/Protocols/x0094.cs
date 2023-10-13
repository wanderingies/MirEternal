#pragma warning disable CS8618

using TouchSocket.Core;
using GameServer.Service;

namespace GameServer.Packs.Protocols
{
    /// <summary>
    /// <para>玩家同意交易</para>
    /// <para>货币描述</para>
    /// </summary>
    internal class x0094 : Package
    {
        #region public

        public int 对象编号;
        #endregion

        #region marshal

        public byte U1;
        public byte[] CurrencyInfo;
        #endregion

        #region attribute

        public ushort Type => 0x0094;
        public ushort Size => 6;
        public ushort rSize => 0;
        #endregion

        public x0094()
        {
            U1 = 1;
            var data = new uint[][]{
                new uint[] { 0, 5000000, 0, 0, 0, 999999999, 0, 0 },
                new uint[] { 0, 3567587328, 232, 2147483647, 0, 0, 0, 0 },
                new uint[] { 0, 3567587328, 232, 0, 0, 0, 0, 100000 },
                new uint[] { 0, 3567587328, 232, 0, 0, 0, 0, 0 },
                new uint[] { 0, 0, 0, 0, 0, 0, 0, 1000000 },
                new uint[] { 0, 3567587328, 232, 0, 0, 0, 0, 1000000 },
                new uint[] { 0, 3567587328, 232, 0, 0, 0, 0, 10000000 },
                new uint[] { 0, 3567587328, 232, 0, 0, 0, 0, 1000000 },
                new uint[] { 0, 4000, 0, 0, 0, 0, 0, 2000 },
                new uint[] { 0, 100000000, 0, 100000000, 0, 0, 0, 100000000 },
                new uint[] { 0, 3567587328, 232, 0, 0, 0, 0, 1000000 },
                new uint[] { 0, 3567587328, 232, 0, 0, 0, 0, 10000000 },
                new uint[] { 0, 100000, 0, 0, 0, 0, 0, 10000 },
                new uint[] { 0, 3567587328, 232, 0, 0, 0, 0, 1000000 },
                new uint[] { 0, 100000000, 0, 100000000, 0, 0, 0, 100000000 },
                new uint[] { 0, 100000000, 0, 100000000, 0, 0, 0, 100000000 },
                new uint[] { 0, 100000000, 0, 20000, 0, 0, 0, 100000000 },
                new uint[] { 0, 3567587328, 232, 0, 0, 0, 0, 100000000 },
                new uint[] { 0, 3567587328, 232, 0, 0, 0, 0, 100000000 },
                new uint[] { 0, 3567587328, 232, 0, 0, 0, 0, 100000000 },
            };

            using (MemoryStream memoryStream = new MemoryStream())
            {
                using (BinaryWriter binaryWriter = new BinaryWriter(memoryStream))
                {
                    for (int i = 0; i <= 19; i++)
                    {
                        binaryWriter.Seek(i * 48, SeekOrigin.Begin);
                        binaryWriter.Write(i * 100/*CharacterData.Currencies[(GameCurrency)i]*/);
                        for (var c = 0; c < data[c].Length; c++)
                            binaryWriter.Write(data[i][c]);
                    }

                    CurrencyInfo = memoryStream.ToArray();
                }
            }
        }

        #region private


        #endregion

        public ByteBlock Marshal(ByteBlock byteBlock)
        {
            byteBlock.Write(U1);
            byteBlock.Write(CurrencyInfo);
            return byteBlock;
        }

        public ByteBlock UnMarshal(ByteBlock byteBlock)
        {
            对象编号 = byteBlock.ReadInt32();
            return byteBlock;
        }

        public void Process(GameSession gameSession)
        {
            throw new NotImplementedException();
        }
    }
}

