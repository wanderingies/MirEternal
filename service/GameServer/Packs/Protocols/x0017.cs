#pragma warning disable CS8618

using TouchSocket.Core;
using GameServer.Service;

namespace GameServer.Packs.Protocols
{
    /// <summary>
    /// <para>帧同步, 请求Ping</para>
    /// <para>客户网速测试</para>
    /// </summary>
    internal class x0017 : Package
    {
        #region public

        public int ClientTime;
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
            ClientTime = byteBlock.ReadInt32();
            return byteBlock;
        }

        public void Process(GameSession gameSession)
        {
            var x2d = new x002D() { SyncTime = ClientTime };
            gameSession.SendPackage(x2d.Type, x2d.rSize, x2d);
        }
    }
}

