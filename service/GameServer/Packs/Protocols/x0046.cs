#pragma warning disable CS8618

using TouchSocket.Core;
using GameServer.Service;

namespace GameServer.Packs.Protocol
{
    /// <summary>
    /// <para>OrdinaryInscriptionRefinementPacket</para>
    /// <para>OrdinaryInscriptionRefinementPacket</para>
    /// </summary>
    internal class x0046 : Package
    {
        #region public

		public Byte 装备类型;
		public Byte 装备位置;
		public Int32 Id;
        #endregion

        #region marshal


        #endregion

        #region attribute

        public ushort Type => 0x0046;
        public ushort Size => 8;     
        public ushort rSize => 0;
        #endregion
        
        public x0046() 
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
			装备类型 = byteBlock.ReadByte();
			装备位置 = byteBlock.ReadByte();
			Id = byteBlock.ReadInt32();
			return byteBlock;
        }

        public void Process(GameSession gameSession)
        {
            throw new NotImplementedException();
        }
    }
}

