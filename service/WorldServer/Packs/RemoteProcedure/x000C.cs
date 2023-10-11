#pragma warning disable CS8618

using TouchSocket.Core;
using WorldServer.Service;

namespace WorldServer.Packs.Protocol
{
    /// <summary>
    /// <para>同步CharacterData(地图.坐标.职业.性别.等级...)</para>
    /// <para>SyncCharacterPacket</para>
    /// </summary>
    internal class x000C : Package
    {
        #region public field

		public Int32 ObjectId;
		public Int32 CurrentMap;
		public Int32 RouteId;
		public Byte Race;
		public Byte Gender;
		public Byte CurrentLevel;
		public UInt16 CurrentAltitude;
		public UInt16 Direction;
		public UInt16 Distance;
		public Int64 MaxExp;
		public Int64 ExpCap;
		public Int32 DoubleExp;
		public Int32 Unknown3;
		public Int32 PKLevel;
		public Byte AttackMode;
		public Int32 CurrentTime;
		public UInt16 MaxLevel;
		public Int64 CurrentExp;
		public Boolean BrownName;
		public Int32 AwakeningExp;
		public Int32 Unknown8;
		public Int32 MaxAwakeningExp;
		public Int32 Unknown7;
		public UInt16 EquipRepairDto;
        #endregion

        #region public attribute

        public ushort Type => 0x000C;
        public ushort Size => 172;        
        #endregion
        
        #region private field


        #endregion

        public ByteBlock Marshal(ByteBlock byteBlock)
        {
			byteBlock.Write(ObjectId);
			byteBlock.Write(CurrentMap);
			byteBlock.Write(RouteId);
			byteBlock.Write(Race);
			byteBlock.Write(Gender);
			byteBlock.Write(CurrentLevel);
			byteBlock.Write(CurrentAltitude);
			byteBlock.Write(Direction);
			byteBlock.Write(Distance);
			byteBlock.Write(MaxExp);
			byteBlock.Write(ExpCap);
			byteBlock.Write(DoubleExp);
			byteBlock.Write(Unknown3);
			byteBlock.Write(PKLevel);
			byteBlock.Write(AttackMode);
			byteBlock.Write(CurrentTime);
			byteBlock.Write(MaxLevel);
			byteBlock.Write(CurrentExp);
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

        public void Process(WorldSession session)
        {
            
        }
    }
}

