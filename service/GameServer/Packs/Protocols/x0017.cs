#pragma warning disable CS8618

using TouchSocket.Core;
using GameServer.Service;

namespace GameServer.Packs.Protocol
{
    /// <summary>
    /// <para>帧同步, 请求Ping</para>
    /// <para>客户网速测试</para>
    /// </summary>
    internal class x0017 : Package
    {
        #region public

		public Int32 客户时间;
        #endregion

        #region marshal


        #endregion

        #region attribute

        public ushort Type => 0x0017;
        public ushort Size => 6;     
        public ushort rSize => 0;
        #endregion
        
        public x0017() 
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
			客户时间 = byteBlock.ReadInt32();
			return byteBlock;
        }

        public void Process(GameSession gameSession)
        {
            throw new NotImplementedException();
        }
    }
}

