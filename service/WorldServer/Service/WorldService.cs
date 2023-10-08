using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TouchSocket.Sockets;
using WorldServer.Packs;

namespace WorldServer.Service
{
    internal class WorldService : TcpService<WorldSession>
    {
        protected override void OnConnecting(WorldSession socketClient, ConnectingEventArgs e)
        {
            socketClient.SetDataHandlingAdapter(new PackageAdapter());
            base.OnConnecting(socketClient, e);
        }
    }
}
