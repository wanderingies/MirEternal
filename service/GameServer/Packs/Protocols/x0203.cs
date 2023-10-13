#pragma warning disable CS8618

using TouchSocket.Core;
using GameServer.Service;

namespace GameServer.Packs.Protocol
{
    /// <summary>
    /// <para>RequestCharacterDataPacket</para>
    /// <para>RequestCharacterDataPacket</para>
    /// </summary>
    internal class x0203 : Package
    {
        #region public

		public Int32 角色编号;
        #endregion

        #region marshal


        #endregion

        #region attribute

        public ushort Type => 0x0203;
        public ushort Size => 10;     
        public ushort rSize => 0;
        #endregion
        
        public x0203() 
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
			角色编号 = byteBlock.ReadInt32();
			return byteBlock;
        }

        public void Process(GameSession gameSession)
        {
            throw new NotImplementedException();
        }
    }
}

