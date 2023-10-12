using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TouchSocket.Core;
using TouchSocket.Sockets;

namespace LoggerServer.Service
{
    internal class LoggerSession : SocketClient
    {
        protected override bool HandleReceivedData(ByteBlock byteBlock, IRequestInfo requestInfo)
        {
            var messsage = Encoding.UTF8.GetString(byteBlock.Buffer, 0, byteBlock.Len);//注意：数据长度是byteBlock.Len

            var split = messsage.Split(';');
            if(split.Length >= 2)
            {
                switch (split[0])
                {
                    case "Info": Logger.Info(split[1]); break;
                    case "Warning": Logger.Warning(split[1]); break;
                    case "Error": Logger.Error(split[1]); break;
                    default: Logger.Info(split[1]); break;
                }
            }
            else Logger.Info(messsage);
            return true;

            //return base.HandleReceivedData(byteBlock, requestInfo);
        }
    }
}
