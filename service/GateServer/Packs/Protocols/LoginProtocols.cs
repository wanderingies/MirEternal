namespace GateServer.Packs.Protocols
{
    internal class LoginProtocols
    {
        public static readonly Dictionary<ushort, BaseProtocol> Instance;

        static LoginProtocols()
        {
            Instance = new Dictionary<ushort, BaseProtocol>()
            {
                { 0x03E9, new BaseProtocol(){Size=162, Name="UserLoginPacket",Description="客户登录" } },
                { 0x03EA, new BaseProtocol(){Size=40, Name="UserCreateRolePacket",Description="创建角色" } },
                { 0x03EB, new BaseProtocol(){Size=6, Name="UserFreezeRolePacket",Description="冻结角色" } },
                { 0x03EC, new BaseProtocol(){Size=6, Name="UserDelectRolePacket",Description="删除角色" } },
                { 0x03ED, new BaseProtocol(){Size=6, Name="UserBackRolePacket",Description="找回冻结的角色" } },
                { 0x03EE, new BaseProtocol(){Size=6, Name="UserEnterPacket",Description="进入游戏" } },
                { 0x03EF, new BaseProtocol(){Size=6, Name="TestNetworkSpeedPacket",Description="测试网关网速" } },
                { 0x03F0, new BaseProtocol(){Size=38, Name="UserChangeRolePacket",Description="更改角色名称" } },
            };
        }
    }
}
