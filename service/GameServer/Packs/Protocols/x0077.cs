#pragma warning disable CS8618

using TouchSocket.Core;
using GameServer.Service;

namespace GameServer.Packs.Protocol
{
    /// <summary>
    /// <para>提交选项继续NPC对话</para>
    /// <para>继续Npcc对话</para>
    /// </summary>
    internal class x0077 : Package
    {
        #region public field

		public Int32 Id;
        #endregion

        #region public attribute

        public ushort Type => 0x0077;
        public ushort Size => 6;        
        #endregion
        
        #region private field


        #endregion

        public ByteBlock Marshal(ByteBlock byteBlock)
        {
            return byteBlock;
        }

        public ByteBlock UnMarshal(ByteBlock byteBlock)
        {
			Id = byteBlock.ReadInt32();
            return byteBlock;
        }

        public void Process(GameSession session)
        {
            
        }
    }
}

