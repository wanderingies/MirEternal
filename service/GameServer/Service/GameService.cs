using GameServer.Packs;
using TouchSocket.Sockets;

namespace GameServer.Service
{
    internal class GameService : TcpService<GameSession>
    {
        public GameService()
        {
            #region ClientSession

            clientSession = new ClientSession();
            clientSession.SetHost("127.0.0.1:29110");
            clientSession.Connect();
            #endregion
        }

        private readonly ClientSession clientSession;

        protected override void OnConnecting(GameSession socketClient, ConnectingEventArgs e)
        {
            socketClient.SetDataHandlingAdapter(new PackageAdapter());
            base.OnConnecting(socketClient, e);
        }
    }
}
