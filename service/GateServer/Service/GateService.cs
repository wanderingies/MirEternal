#pragma warning disable CS8618

using GateServer.Data.Enums;
using GateServer.Packs;
using GateServer.Packs.Protocols;
using ThreadPooling;
using TouchSocket.Core;
using TouchSocket.Sockets;
using ThreadPool = ThreadPooling.ThreadPool;

namespace GateServer.Service
{
    internal class GateService : TcpService<GateSession>
    {
        public static GateService Instance { get; private set; }

        public GateService()
        {
            #region ThreadPool

            //threadPool = new ThreadPool(Environment.ProcessorCount * 4, "MirWorker");
            #endregion

            Instance = this;
        }

        #region ThreadPool

        //private ThreadPool threadPool;
        //private IWorkItemState workItemState;
        //private List<IWorkItemState> wirs = new List<IWorkItemState>();
        #endregion

        public static Dictionary<string, ClientSession> LoginClients { get; set; } = new Dictionary<string, ClientSession>();
        public static Dictionary<string, ClientSession> GameClients { get; set; } = new Dictionary<string, ClientSession>();
        public static Dictionary<string, ClientSession> WorldClients { get; set; } = new Dictionary<string, ClientSession>();

        protected override void OnConnecting(GateSession socketClient, ConnectingEventArgs e)
        {
            socketClient.SetDataHandlingAdapter(new PackageAdapter());
            base.OnConnecting(socketClient, e);
        }

        protected override void OnDisconnected(GateSession socketClient, DisconnectEventArgs e)
        {
            LoginClients.Remove(socketClient.Id);
            GameClients.Remove(socketClient.Id);
            WorldClients.Remove(socketClient.Id);

            base.OnDisconnected(socketClient, e);
        }

        protected override void OnReceived(GateSession socketClient, ByteBlock byteBlock, IRequestInfo requestInfo)
        {
            var request = requestInfo as PackageRequest;
            if (request != null)
            {
                if (LoginProtocols.Instance.TryGetValue(request.Type, out var value))
                {
                    if (LoginClients.TryGetValue(socketClient.Id, out var client))
                        client.Send(request.Buffer);
                    else
                    {
                        var LoginClient = new ClientSession() { SessionId = socketClient.Id };
                        LoginClient.SetHost("127.0.0.1:29200");
                        LoginClient.Connect();

                        LoginClient.Send(request.Buffer);
                        LoginClients.Add(socketClient.Id, LoginClient);

                        LoginClient.Logger.Info($"{socketClient.Id} => 连接登陆服务器");
                    }

                    if (!GameClients.ContainsKey(socketClient.Id))
                    {
                        var gameClient = new ClientSession() { SessionId = socketClient.Id };
                        gameClient.SetHost("127.0.0.1:29300");
                        gameClient.Connect();

                        //gameClient.Send(request.Buffer);
                        GameClients.Add(socketClient.Id, gameClient);

                        gameClient.Logger.Info($"{socketClient.Id} => 连接游戏服务器");
                        //GameClients.Add(socketClient.Id, new ClientSession() { SessionId = socketClient.Id });
                    }

                    if (!WorldClients.ContainsKey(socketClient.Id))
                    {
                        var WorldClient = new ClientSession() { SessionId = socketClient.Id };
                        WorldClient.SetHost("127.0.0.1:29301");
                        WorldClient.Connect();

                        //WorldClient.Send(request.Buffer);
                        WorldClients.Add(socketClient.Id, WorldClient);

                        WorldClient.Logger.Info($"{socketClient.Id} => 连接世界服务器");
                        //WorldClients.Add(socketClient.Id, new ClientSession() { SessionId = socketClient.Id });
                    }                    
                    //workItemState = threadPool.EnqueueWorkItem(LoginReceivedCallbackFunction, socketClient.Id, request.Buffer);
                    //wirs.Add(workItemState);
                }

                if(GameProtocols.Instance.TryGetValue(request.Type, out value))
                {
                    if(GameClients.TryGetValue(socketClient.Id,out var client))
                        client.Send(request.Buffer);
                    else
                    {
                        var gameClient = new ClientSession() { SessionId = socketClient.Id };
                        gameClient.SetHost("127.0.0.1:29300");
                        gameClient.Connect();

                        gameClient.Send(request.Buffer);
                        WorldClients.Add(socketClient.Id, gameClient);

                        //gameClient.Logger.Info("登记连接游戏服务器");
                    }
                }

                if (WorldProtocols.Instance.TryGetValue(request.Type, out value))
                {
                    if (WorldClients.TryGetValue(socketClient.Id, out var client))
                        client.Send(request.Buffer);
                    else
                    {
                        var WorldClient = new ClientSession() { SessionId = socketClient.Id };
                        WorldClient.SetHost("127.0.0.1:29301");
                        WorldClient.Connect();

                        WorldClient.Send(request.Buffer);
                        WorldClients.Add(socketClient.Id, WorldClient);

                        //WorldClient.Logger.Info("登记连接世界服务器");
                    }
                    //workItemState = threadPool.EnqueueWorkItem(WorldReceivedCallbackFunction, socketClient.Id, request.Buffer);
                    //wirs.Add(workItemState);
                }
            }
        }

        private void LoginReceivedCallbackFunction(string value, byte[] buffer)
        {
            if(LoginClients.TryGetValue(value, out var client))
                client.Send(buffer);
            else
            {
                var LoginClient = new ClientSession();
                LoginClient.SetHost("127.0.0.1:29200");

                LoginClient.Connect();

                LoginClient.Send(buffer);
                LoginClients.Add(value, LoginClient);

                LoginClient.Logger.Info("登记连接登陆服务器");
            }            
        }

        private void WorldReceivedCallbackFunction(string value, byte[] buffer)
        {
            if(WorldClients.TryGetValue(value, out var client))
                client.Send(buffer);
            else
            {
                var WorldClient = new ClientSession();
                WorldClient.SetHost("127.0.0.1:29301");

                WorldClient.Connect();

                WorldClient.Send(buffer);
                WorldClients.Add(value, WorldClient);

                WorldClient.Logger.Info("登记连接游戏服务器");
            }            
        }
    }
}
