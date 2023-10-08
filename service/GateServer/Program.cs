#pragma warning disable CS0649
#pragma warning disable CS8618

using TouchSocket.Core;
using TouchSocket.Sockets;

using GateServer.Service;
using System.Runtime.InteropServices;

namespace GateServer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region GateService

            service = new GateService();
            service.Setup(new TouchSocketConfig()//载入配置     
                .SetListenIPHosts("tcp://127.0.0.1:29000")
                .ConfigureContainer(a =>//容器的配置顺序应该在最前面
                {
                    a.AddConsoleLogger();//添加一个控制台日志注入（注意：在maui中控制台日志不可用）
                })
                .ConfigurePlugins(a =>
                {
                    a.UseReconnection()
                     .SetTick(TimeSpan.FromSeconds(1))
                     .UsePolling();
                }))
                .Start();//启动

            service.Logger.Info("网关服务器启动成功");
            #endregion

            bool isSuccess = SetConsoleCtrlHandler(consoleCtrlDelegate, true);
            Thread.CurrentThread.IsBackground = false;
            Thread.Sleep(Timeout.Infinite);
        }
        
        public static GateService service;

        #region capture event

        #region kernel32

        private delegate bool ConsoleEventDelegate(int eventType);

        [DllImport("kernel32.dll", SetLastError = true)]
        private static extern bool SetConsoleCtrlHandler(ConsoleEventDelegate callback, bool add);

        volatile static ConsoleEventDelegate consoleCtrlDelegate = new ConsoleEventDelegate(HandlerRoutine);

        #endregion

        public static bool HandlerRoutine(int CtrlType)
        {
            switch (CtrlType)
            {
                case 0:
                    break;
                case 2:
                    break;
            }

            return false;
        }
        #endregion
    }
}