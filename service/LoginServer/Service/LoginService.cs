﻿using LoginServer.Packs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TouchSocket.Core;
using TouchSocket.Sockets;

namespace LoginServer.Service
{
    internal class LoginService : TcpService<LoginSession>
    {
        protected override void OnConnecting(LoginSession socketClient, ConnectingEventArgs e)
        {
            Logger.Info("客户正在在接入 ...");
            socketClient.SetDataHandlingAdapter(new PackageAdapter());
            base.OnConnecting(socketClient, e);
        }
    }
}