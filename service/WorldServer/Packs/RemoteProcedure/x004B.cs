#pragma warning disable CS8618

using TouchSocket.Core;
using WorldServer.Service;

namespace WorldServer.Packs.Protocol
{
    /// <summary>
    /// <para>CharacterExpChangesPacket</para>
    /// <para>CharacterExpChangesPacket</para>
    /// </summary>
    internal class x004B : Package
    {
        #region public field

		public Int32 经验增加;
		public Int32 今日增加;
		public Int32 经验上限;
		public Int32 DoubleExp;
		public Int64 CurrentExp;
		public Int64 升级所需;
		public Int32 GainAwakeningExp;
		public Int32 MaxAwakeningExp;
        #endregion

        #region public attribute

        public ushort Type => 0x004B;
        public ushort Size => 46;        
        #endregion
        
        #region private field


        #endregion

        public ByteBlock Marshal(ByteBlock byteBlock)
        {
			byteBlock.Write(经验增加);
			byteBlock.Write(今日增加);
			byteBlock.Write(经验上限);
			byteBlock.Write(DoubleExp);
			byteBlock.Write(CurrentExp);
			byteBlock.Write(升级所需);
			byteBlock.Write(GainAwakeningExp);
			byteBlock.Write(MaxAwakeningExp);
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

