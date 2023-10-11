#pragma warning disable CS0649
#pragma warning disable CS8618

using TouchSocket.Core;
using TouchSocket.Sockets;

namespace GameServer.Service
{
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

        public string SessionId { get; set; }
    }
}
