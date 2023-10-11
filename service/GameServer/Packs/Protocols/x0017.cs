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
        #region public field

		public Int32 Synchronisedtime;
        #endregion

        #region public attribute

        public ushort Type => 0x0017;
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
			Synchronisedtime = byteBlock.ReadInt32();
            return byteBlock;
        }

        public void Process(GameSession session)
        {
            var pack = new x002D();
            session.SendPackage(pack.Type, pack.Size, pack);
        }
    }
}

