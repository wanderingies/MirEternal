#pragma warning disable CS8618

using TouchSocket.Core;
using GameServer.Service;

namespace GameServer.Packs.Protocol
{
    /// <summary>
    /// <para>ClickNpcDialogPacket</para>
    /// <para>ClickNpcDialogPacket</para>
    /// </summary>
    internal class x0071 : Package
    {
        #region public

		public Int32 对象编号;
		public Int32 QuestId;
		public Int32 Unknown;
        #endregion

        #region marshal


        #endregion

        #region attribute

        public ushort Type => 0x0071;
        public ushort Size => 14;     
        public ushort rSize => 0;
        #endregion
        
        public x0071() 
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
			对象编号 = byteBlock.ReadInt32();
			QuestId = byteBlock.ReadInt32();
			Unknown = byteBlock.ReadInt32();
			return byteBlock;
        }

        public void Process(GameSession gameSession)
        {
            throw new NotImplementedException();
        }
    }
}

