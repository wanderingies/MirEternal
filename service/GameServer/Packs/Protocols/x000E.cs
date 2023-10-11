#pragma warning disable CS8618

using TouchSocket.Core;
using GameServer.Service;

namespace GameServer.Packs.Protocol
{
    /// <summary>
    /// <para>上传角色位置</para>
    /// <para>上传角色位置</para>
    /// </summary>
    internal class x000E : Package
    {
        #region public field

		public UInt16 高度;

        public byte[] Result;
        #endregion

        #region public attribute

        public ushort Type => 0x000E;
        public ushort Size => 10;        
        #endregion

        public x000E() 
        {
            Result = new byte[] { 0 };
        }
        
        #region private field


        #endregion

        public ByteBlock Marshal(ByteBlock byteBlock)
        {
            byteBlock.Write(Result);
            return byteBlock;
        }

        public ByteBlock UnMarshal(ByteBlock byteBlock)
        {
			高度 = byteBlock.ReadUInt16();
            return byteBlock;
        }

        public void Process(GameSession session)
        {
            
        }
    }
}

