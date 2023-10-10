namespace GateServer.Packs.Protocols
{
    internal class LoginProtocols
    {
        public static readonly Dictionary<ushort, BaseProtocol> Instance;

        static LoginProtocols()
        {
            Instance = new Dictionary<ushort, BaseProtocol>()
            {
                { 1001, new BaseProtocol(){Size=162, Name="UserLoginPacket",Description="客户登录" } },
                { 1002, new BaseProtocol(){Size=40, Name="UserCreateRolePacket",Description="创建角色" } },
                { 1003, new BaseProtocol(){Size=6, Name="UserFreezeRolePacket",Description="冻结角色" } },
                { 1004, new BaseProtocol(){Size=6, Name="UserDelectRolePacket",Description="删除角色" } },
                { 1005, new BaseProtocol(){Size=6, Name="UserBackRolePacket",Description="找回冻结的角色" } },
                { 1006, new BaseProtocol(){Size=6, Name="UserEnterPacket",Description="进入游戏" } },
                { 1007, new BaseProtocol(){Size=6, Name="TestNetworkSpeedPacket",Description="测试网关网速" } },
                { 1008, new BaseProtocol(){Size=38, Name="UserChangeRolePacket",Description="更改角色名称" } },
            };
        }
    }
}
