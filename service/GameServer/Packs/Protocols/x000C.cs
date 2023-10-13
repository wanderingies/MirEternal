#pragma warning disable CS8618

using TouchSocket.Core;
using GameServer.Service;
using System.Drawing;

namespace GameServer.Packs.Protocols
{
    /// <summary>
    /// <para>场景加载完成</para>
    /// <para>场景加载完成</para>
    /// </summary>
    internal class x000C : Package
    {
        #region public

        #endregion

        #region marshal

        public int RoleId;
        public int Map;
        public int RouteId;
        public byte Race;
        public byte Gender;
        public byte Level;
        public byte[] Unknown1;
        public Point Position;
        public ushort Altitude;
        public ushort Direction;
        public ushort Distance;
        public long MaxExp;
        public long ExpCap;
        public int DoubleExp;
        public int Unknown3;
        public int PkLevel;
        public byte AttackMode;
        public byte[] Unknown4;
        public int CurrentTime;
        public byte[] Unknown5;
        public ushort MaxLevel;
        public byte[] Unknown6;
        public long Exp;
        public bool BrownName;
        public int AwakeningExp;
        public int Unknown8;
        public int MaxAwakeningExp;
        public int Unknown7;
        public ushort EquipRepairDto;
        #endregion

        #region attribute

        public ushort Type => 0x000C;
        public ushort Size => 10;
        public ushort rSize => 172;
        #endregion

        public x000C()
        {
            Unknown1 = new byte[45];
            ExpCap = 0x7FFFFFFF00000000;
            Unknown4 = new byte[16];
            Unknown5 = new byte[14];
            Unknown6 = new byte[8];
            BrownName = false;
        }

        #region private


        #endregion

        public ByteBlock Marshal(ByteBlock byteBlock)
        {
            byteBlock.Write(RoleId);
            byteBlock.Write(Map);
            byteBlock.Write(RouteId);
            byteBlock.Write(Race);
            byteBlock.Write(Gender);
            byteBlock.Write(Level);
            byteBlock.Write(Unknown1);
            var point = Utility.UtilityLibrary.点阵坐标转协议坐标(Position);
            byteBlock.Write((ushort)point.X);
            byteBlock.Write((ushort)point.Y);
            byteBlock.Write(Altitude);
            byteBlock.Write(Direction);
            byteBlock.Write(Distance);
            byteBlock.Write(MaxExp);
            byteBlock.Write(ExpCap);
            byteBlock.Write(DoubleExp);
            byteBlock.Write(Unknown3);
            byteBlock.Write(PkLevel);
            byteBlock.Write(AttackMode);
            byteBlock.Write(Unknown4);
            byteBlock.Write(CurrentTime);
            byteBlock.Write(Unknown5);
            byteBlock.Write(MaxLevel);
            byteBlock.Write(Unknown6);
            byteBlock.Write(Exp);
            byteBlock.Write(BrownName);
            byteBlock.Write(AwakeningExp);
            byteBlock.Write(Unknown8);
            byteBlock.Write(MaxAwakeningExp);
            byteBlock.Write(Unknown7);
            byteBlock.Write(EquipRepairDto);
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

