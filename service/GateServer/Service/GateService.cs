using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TouchSocket.Core;
using TouchSocket.Sockets;

namespace GateServer.Service
{
    internal class GateService : TcpService<GateSession>
    {
        protected override void OnConnecting(GateSession socketClient, ConnectingEventArgs e)
        {
            base.OnConnecting(socketClient, e);
        }

        protected override void OnConnected(GateSession socketClient, ConnectedEventArgs e)
        {
            base.OnConnected(socketClient, e);
        }

        protected override void OnDisconnecting(GateSession socketClient, DisconnectEventArgs e)
        {
            base.OnDisconnecting(socketClient, e);
        }

        protected override void OnDisconnected(GateSession socketClient, DisconnectEventArgs e)
        {
            base.OnDisconnected(socketClient, e);
        }

        protected override void OnReceived(GateSession socketClient, ByteBlock byteBlock, IRequestInfo requestInfo)
        {
            base.OnReceived(socketClient, byteBlock, requestInfo);
        }
    }
}
