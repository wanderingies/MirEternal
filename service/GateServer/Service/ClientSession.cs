#pragma warning disable CS0649
#pragma warning disable CS8618

using GateServer.Data.Enums;
using TouchSocket.Core;
using TouchSocket.Sockets;

namespace GateServer.Service
{
    /// <summary>
    /// 客户端  <=> 子服务器
    /// </summary>
    internal class ClientSession : TcpClient
    {
        public void SetHost(string host)
        {
            var config = new TouchSocketConfig()
                .SetRemoteIPHost(host)
                .ConfigureContainer(a =>
                {
                    a.AddConsoleLogger();//添加一个日志注入
                })
                .ConfigurePlugins(a =>
                {
                    a.UseReconnection()
                     .SetTick(TimeSpan.FromSeconds(1))
                     .UsePolling();

                });

            Setup(config);
        }

        public string SessionId {  get; set; }

        protected override bool HandleReceivedData(ByteBlock byteBlock, IRequestInfo requestInfo)
        {
            var client = GateService.Instance.GetClients().Where(q => q.Id == SessionId).FirstOrDefault();
            if (client != null)
            {
                if (client.SessionState != SessionState.None && client.SessionState == SessionState.UserInLogin && byteBlock.Len == 43)
                {
                    client.SessionState = SessionState.RoleInGame;
                    if (GateService.GameClients.TryGetValue(SessionId, out var gameClient))
                        gameClient.Send(byteBlock.Buffer, 0, byteBlock.Len);

                    if (GateService.WorldClients.TryGetValue(SessionId, out var worldClient))
                        worldClient.Send(byteBlock.Buffer, 0, byteBlock.Len);
                }
                else client.Send(byteBlock.Buffer, 0, byteBlock.Len);

                return true;
            }

            return false;
        }
    }
}
