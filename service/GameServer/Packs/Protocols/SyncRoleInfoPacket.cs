#pragma warning disable CS0649

using GameServer.Service;
using System.Drawing;
using TouchSocket.Core;

namespace GameServer.Packs.Protocols
{
    /// <summary>
    /// 同步角色信息
    /// </summary>
    internal class SyncRoleInfoPacket : Package
    {
        public int RoleId;
        public int Map;
        public int RouteId;
        public byte Race;
        public byte Gender;
        public byte Level;
        public byte[] Unknown1 = new byte[45];
        public Point Position;
        public ushort Altitude;
        public ushort Direction;
        /// <summary>
        /// 距离
        /// </summary>
        public byte Distance = 1;
        public byte Offline = 2;
        public long NeedExp;
        public long MaxExp = 9223372032559808512L;
        public int DoubleExp;
        public int Unknown3 = 0;
        public int PkLevel;
        public byte AttackMode;
        public byte[] Unknown4 = new byte[16];
        public int CurrentTime;
        public byte[] Unknown5 = new byte[14];
        public ushort MaxLevel;
        public byte[] Unknown6 = new byte[8];
        public long Exp;
        public bool BrownName = false;
        public int AwakeningExp;
        public int Unknown8;
        public int MaxAwakeningExp;
        public int Unknown7;
        public ushort EquipRepairDto;

        public ushort Type => 12;

        public ushort Size => 172;

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
            byteBlock.Write((short)point.X);
            byteBlock.Write((short)point.Y);
            byteBlock.Write(Altitude);
            byteBlock.Write(Direction);
            byteBlock.Write(Distance);
            byteBlock.Write(Offline);
            byteBlock.Write(NeedExp);
            byteBlock.Write(MaxExp);
            byteBlock.Write(DoubleExp);
            byteBlock.Write(Unknown3 = 0);
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

        public void Process(GameSession gateSession)
        {
            throw new NotImplementedException();
        }
    }
}
