﻿#pragma warning disable CS8618

using GameServer.Service;
using TouchSocket.Core;

namespace GameServer.Packs.Protocols
{
    /// <summary>
    /// <para>-</para>
    /// <para>角色外观</para>
    /// </summary>
    internal class x0040 : Package
    {
        #region public

        #endregion

        #region marshal

        public Int32 ObjectId;
        public Byte Unknown1;
        public Byte Race;
        public Byte Gender;
        public Byte HairType;
        public Byte HairColor;
        public Byte Face;
        public Byte Unknown2;
        public Byte Unknown3;
        public Int32 PKLevel;
        public byte[] Unknown4;
        public Byte WeaponType;
        public Int32 WeaponBody;
        public Int32 Clothes;
        public Int32 Cloak;
        public Int32 CurrentHP;
        public Int32 CurrentMP;
        public byte[] Unknown5;
        public Int32 AppearanceTime;
        public Byte StallStatus;
        public String BoothName;
        public String Name;
        public Int32 GuildId;
        #endregion

        #region attribute

        public ushort Type => 0x0040;
        public ushort Size => 0;
        public ushort rSize => 133;
        #endregion

        public x0040()
        {
            Unknown4 = new byte[4];
            Unknown5 = new byte[6];
        }

        #region private


        #endregion

        public ByteBlock Marshal(ByteBlock byteBlock)
        {
            byteBlock.Write(ObjectId);
            byteBlock.Write(Unknown1);
            byteBlock.Write(Race);
            byteBlock.Write(Gender);
            byteBlock.Write(HairType);
            byteBlock.Write(HairColor);
            byteBlock.Write(Face);
            byteBlock.Write(Unknown2);
            byteBlock.Write(Unknown3);
            byteBlock.Write(PKLevel);
            byteBlock.Write(Unknown4);
            byteBlock.Write(WeaponType);
            byteBlock.Write(WeaponBody);
            byteBlock.Write(Clothes);
            byteBlock.Write(Cloak);
            byteBlock.Write(CurrentHP);
            byteBlock.Write(CurrentMP);
            byteBlock.Write(Unknown5);
            byteBlock.Write(AppearanceTime);
            byteBlock.Write(StallStatus);
            byteBlock.Write(BoothName);
            byteBlock.Write(Name);
            byteBlock.Write(GuildId);
            return byteBlock;
        }

        public ByteBlock UnMarshal(ByteBlock byteBlock)
        {
            throw new NotImplementedException();
        }

        public void Process(GameSession gameSession)
        {
            throw new NotImplementedException();
        }
    }
}