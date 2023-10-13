#pragma warning disable CS8618

using TouchSocket.Core;
using GameServer.Service;

namespace GameServer.Packs.Protocol
{
    /// <summary>
    /// <para>申请更改队伍</para>
    /// <para>申请更改队伍</para>
    /// </summary>
    internal class x0207 : Package
    {
        #region public

		public Int32 成员上限;
		public Int32 队长编号;
        #endregion

        #region marshal


        #endregion

        #region attribute

        public ushort Type => 0x0207;
        public ushort Size => 44;     
        public ushort rSize => 0;
        #endregion
        
        public x0207() 
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
			成员上限 = byteBlock.ReadInt32();
			队长编号 = byteBlock.ReadInt32();
			return byteBlock;
        }

        public void Process(GameSession gameSession)
        {
            throw new NotImplementedException();
        }
    }
}

