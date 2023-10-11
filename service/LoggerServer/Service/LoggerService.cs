using System.Text;
using TouchSocket.Core;
using TouchSocket.Sockets;

namespace LoggerServer.Service
{
    internal class LoggerService : TcpService<LoggerSession>
    {
        protected override void OnReceived(LoggerSession socketClient, ByteBlock byteBlock, IRequestInfo requestInfo)
        {
            var messsage = Encoding.UTF8.GetString(byteBlock.Buffer, 0, byteBlock.Len);//注意：数据长度是byteBlock.Len
            socketClient.Logger.Info(messsage);

            //base.OnReceived(socketClient, byteBlock, requestInfo);
        }
    }
}
