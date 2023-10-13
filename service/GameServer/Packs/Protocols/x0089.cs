#pragma warning disable CS8618

using TouchSocket.Core;
using GameServer.Service;
using System;

namespace GameServer.Packs.Protocols
{
    /// <summary>
    /// <para>上传游戏设置</para>
    /// <para>上传游戏设置</para>
    /// </summary>
    internal class x0089 : Package
    {
        #region public

        public byte[] Setting;
        #endregion

        #region marshal


        #endregion

        #region attribute

        public ushort Type => 0x0089;
        public ushort Size => 0;
        public ushort rSize => 0;
        #endregion

        public x0089()
        {
        }

        #region private


        #endregion

        public ByteBlock Marshal(ByteBlock byteBlock)
        {
            throw new NotImplementedException();
        }

        public ByteBlock UnMarshal(ByteBlock byteBlock)
        {
            Setting = new byte[byteBlock.Len];
            byteBlock.Read(Setting, 0, byteBlock.Len);
            return byteBlock;
        }

        public void Process(GameSession gameSession)
        {
            using (MemoryStream memoryStream = new MemoryStream(Setting))
            {
                using (BinaryReader binaryReader = new BinaryReader(memoryStream))
                {
                    int num = Setting.Length / 5;
                    for (int i = 0; i < num; i++)
                    {
                        byte index = binaryReader.ReadByte();
                        uint value = binaryReader.ReadUInt32();
                        //this.CharacterData.Settings[(int)index] = value;
                    }
                }
            }

            Program.service.Logger.Warning($"0x0089 => 客户端返回游戏设置(未设置)");
        }
    }
}

