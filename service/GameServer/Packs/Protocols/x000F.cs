﻿#pragma warning disable CS8618

using TouchSocket.Core;
using GameServer.Service;

namespace GameServer.Packs.Protocol
{
    /// <summary>
    /// <para>到达传送门/摆摊点</para>
    /// <para>客户碰触法阵</para>
    /// </summary>
    internal class x000F : Package
    {
        #region public field

        public byte PackSize;
        public byte BackpackSize;
        public byte WarehouseSize;
        public byte u1;
        public byte u2;
        public byte u3;
        public byte u4;
        public byte ExtraBackpackSize;
        public byte u5;
        #endregion

        #region public attribute

        public ushort Type => 0x000F;
        public ushort Size => 2;        
        #endregion
        
        #region private field


        #endregion

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
            return byteBlock;
        }

        public void Process(GameSession session)
        {
            
        }
    }
}
