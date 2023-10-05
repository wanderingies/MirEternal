using GateServer.Service;
using TouchSocket.Core;
using TouchSocket.Sockets;

namespace GateServer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            service = new GateService();

            service.Setup(new TouchSocketConfig()//载入配置     
                .SetListenIPHosts("tcp://127.0.0.1:29301")
                .ConfigureContainer(a =>//容器的配置顺序应该在最前面
                {
                    a.AddConsoleLogger();//添加一个控制台日志注入（注意：在maui中控制台日志不可用）
                })
                .ConfigurePlugins(a =>
                {
                    //a.Add();//此处可以添加插件
                }))
                .Start();//启动
        }

        public static GateService service;
    }
}