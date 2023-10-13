#pragma warning disable CS8618

using TouchSocket.Core;
using GameServer.Service;
using System.Drawing;

namespace GameServer.Packs.Protocol
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

        public Int32 RoleId;
        public Int32 Map;
        public Int32 RouteId;
        public Byte Race;
        public Byte Gender;
        public Byte Level;
        public byte[] Unknown1;
        public Point Position;
        public UInt16 Altitude;
        public UInt16 Direction;
        public UInt16 Distance;
        public Int64 MaxExp;
        public Int64 ExpCap;
        public Int32 DoubleExp;
        public Int32 Unknown3;
        public Int32 PkLevel;
        public Byte AttackMode;
        public byte[] Unknown4;
        public Int32 CurrentTime;
        public byte[] Unknown5;
        public UInt16 MaxLevel;
        public byte[] Unknown6;
        public Int64 Exp;
        public Boolean BrownName;
        public Int32 AwakeningExp;
        public Int32 Unknown8;
        public Int32 MaxAwakeningExp;
        public Int32 Unknown7;
        public UInt16 EquipRepairDto;
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

