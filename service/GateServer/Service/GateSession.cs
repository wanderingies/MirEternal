using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TouchSocket.Core;
using TouchSocket.Sockets;

namespace GateServer.Service
{
    internal class GateSession : SocketClient
    {
        protected override void OnConnecting(ConnectingEventArgs e)
        {
            base.OnConnecting(e);
        }

        protected override void OnConnected(ConnectedEventArgs e)
        {
            base.OnConnected(e);
        }

        protected override void OnDisconnecting(DisconnectEventArgs e)
        {
            base.OnDisconnecting(e);
        }

        protected override void OnDisconnected(DisconnectEventArgs e)
        {
            base.OnDisconnected(e);
        }

        protected override bool HandleSendingData(byte[] buffer, int offset, int length)
        {
            return base.HandleSendingData(buffer, offset, length);
        }

        protected override bool HandleReceivedData(ByteBlock byteBlock, IRequestInfo requestInfo)
        {
            return base.HandleReceivedData(byteBlock, requestInfo);
        }
    }
}
