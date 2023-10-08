using GameServer.Packs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TouchSocket.Sockets;

namespace GameServer.Service
{
    internal class GameService : TcpService<GameSession>
    {
        protected override void OnConnecting(GameSession socketClient, ConnectingEventArgs e)
        {
            socketClient.SetDataHandlingAdapter(new PackageAdapter());
            base.OnConnecting(socketClient, e);
        }
    }
}
