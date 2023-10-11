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
        #region public field

		public Int32 成员上限;
		public Int32 队长编号;
        #endregion

        #region public attribute

        public ushort Type => 0x0207;
        public ushort Size => 44;        
        #endregion
        
        #region private field


        #endregion

        public ByteBlock Marshal(ByteBlock byteBlock)
        {
            return byteBlock;
        }

        public ByteBlock UnMarshal(ByteBlock byteBlock)
        {
			成员上限 = byteBlock.ReadInt32();
			队长编号 = byteBlock.ReadInt32();
            return byteBlock;
        }

        public void Process(GameSession session)
        {
            
        }
    }
}

