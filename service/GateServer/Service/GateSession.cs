using GateServer.Data.Enums;
using GateServer.Packs;
using GateServer.Packs.Protocols;
using System.Text;
using TouchSocket.Core;
using TouchSocket.Sockets;

namespace GateServer.Service
{
    /// <summary>
    /// 客户端  => 网关服务器
    /// </summary>
    internal class GateSession : SocketClient
    {
        public SessionState SessionState { get; set; }

        protected override bool HandleReceivedData(ByteBlock byteBlock, IRequestInfo requestInfo)
        {
            var request = requestInfo as PackageRequest;
            if (request != null)
            {
                if (request.Type == 1001)
                {
                    SessionState = SessionState.UserInLogin;
                    request.Buffer = Utility.UtilityLibrary.EncryptionValue(request.Buffer);
                    var ticket = Encoding.UTF8.GetString(request.Buffer, 72, 38);
                    this.ResetId(ticket);
                }
            }

            return base.HandleReceivedData(byteBlock, requestInfo);
        }
    }
}
