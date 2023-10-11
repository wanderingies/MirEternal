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
        #region public field

        public Int32 RoleId;
        public Int32 Map;
        public Int32 RouteId;
        public Byte Race;
        public Byte Gender;
        public Byte Level;
        public byte[] Unknown1 = new byte[45];
        public Point Position;
        public UInt16 Altitude;
        public UInt16 Direction;
        public UInt16 Distance;
        public Int64 MaxExp;
        public Int64 ExpCap = 0x7FFFFFFF00000000;
        public Int32 DoubleExp;
        public Int32 Unknown3;
        public Int32 PkLevel;
        public Byte AttackMode;
        public byte[] Unknown4 = new byte[16];
        public Int32 CurrentTime;
        public byte[] Unknown5 = new byte[14];
        public UInt16 MaxLevel;
        public byte[] Unknown6 = new byte[8];
        public Int64 Exp;
        public Boolean BrownName = false;
        public Int32 AwakeningExp;
        public Int32 Unknown8;
        public Int32 MaxAwakeningExp;
        public Int32 Unknown7;
        public UInt16 EquipRepairDto;
        #endregion

        #region public attribute

        public ushort Type => 0x000C;
        public ushort Size => 10;        
        #endregion
        
        #region private field


        #endregion

        public ByteBlock Marshal(ByteBlock byteBlock)
        {
            byteBlock.Write(RoleId);
            byteBlock.Write(Map);
            byteBlock.Write(RouteId);
            byteBlock.Write(Race);
            byteBlock.Write(Gender);
            byteBlock.Write(Level);
            byteBlock.Write(Altitude);
            byteBlock.Write(Direction);
            byteBlock.Write(Distance);
            byteBlock.Write(ExpCap);
            byteBlock.Write(DoubleExp);
            byteBlock.Write(Unknown3);
            byteBlock.Write(PkLevel);
            byteBlock.Write(AttackMode);
            byteBlock.Write(CurrentTime);
            byteBlock.Write(MaxLevel);
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
            return byteBlock;
        }

        public void Process(GameSession session)
        {
            
        }
    }
}

