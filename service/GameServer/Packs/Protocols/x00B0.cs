#pragma warning disable CS8618

using TouchSocket.Core;
using GameServer.Service;

namespace GameServer.Packs.Protocol
{
    /// <summary>
    /// <para>DistributeGuildBenefitsPacket</para>
    /// <para>DistributeGuildBenefitsPacket</para>
    /// </summary>
    internal class x00B0 : Package
    {
        #region public

		public Byte 发放方式;
		public Int32 发放总额;
		public UInt16 发放人数;
		public Int32 对象编号;
        #endregion

        #region marshal


        #endregion

        #region attribute

        public ushort Type => 0x00B0;
        public ushort Size => 0;     
        public ushort rSize => 0;
        #endregion
        
        public x00B0() 
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
			发放方式 = byteBlock.ReadByte();
			发放总额 = byteBlock.ReadInt32();
			发放人数 = byteBlock.ReadUInt16();
			对象编号 = byteBlock.ReadInt32();
			return byteBlock;
        }

        public void Process(GameSession gameSession)
        {
            throw new NotImplementedException();
        }
    }
}

