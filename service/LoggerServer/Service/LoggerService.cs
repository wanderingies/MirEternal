using System.Text;
using TouchSocket.Core;
using TouchSocket.Sockets;

namespace LoggerServer.Service
{
    internal class LoggerService : TcpService<LoggerSession>
    {
        protected override void OnReceived(LoggerSession socketClient, ByteBlock byteBlock, IRequestInfo requestInfo)
        {
            base.OnReceived(socketClient, byteBlock, requestInfo);
        }
    }
}
