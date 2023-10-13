#pragma warning disable CS0649
#pragma warning disable CS8618

using GameServer.Data;
using GameServer.Service;
using GameServer.Utility;
using System.Text;
using TouchSocket.Core;

namespace GameServer.Packs.Protocols
{
    internal class xFFFF : Package
    {
        public int roleid;
        public string sessionId;

        public ushort Type => ushort.MaxValue;

        public ushort Size => ushort.MaxValue;
        public ushort rSize => ushort.MaxValue;

        public ByteBlock Marshal(ByteBlock byteBlock)
        {
            return byteBlock;
        }        

        public ByteBlock UnMarshal(ByteBlock byteBlock)
        {
            var buffer = new byte[byteBlock.Length];
            byteBlock.Read(buffer, 0, buffer.Length);

            buffer = UtilityLibrary.EncryptionValue(buffer);
            roleid = BitConverter.ToInt32(buffer, 0);
            sessionId = Encoding.UTF8.GetString(buffer, 4, 37);

            return byteBlock;
        }

        public void Process(GameSession gameSession)
        {
            gameSession.SessionId = sessionId;
            Program.service.Logger.Info($"用户({sessionId})角色({roleid}) 进入游戏");

            var xbb = new x00BB();
            xbb = new x00BB() { VariableType = 0x0001, VariableIndex = 0x03AB, VariableKey = roleid, VariableValue = 0x0024 };
            gameSession.SendPackage(xbb.Type, xbb.rSize, xbb);
            xbb = new x00BB() { VariableType = 0x0001, VariableIndex = 0x0319, VariableKey = roleid, VariableValue = 0x0002 };
            gameSession.SendPackage(xbb.Type, xbb.rSize, xbb);
            xbb = new x00BB() { VariableType = 0x0001, VariableIndex = 0x0007, VariableKey = roleid, VariableValue = 0x0000 };
            gameSession.SendPackage(xbb.Type, xbb.rSize, xbb);
            xbb = new x00BB() { VariableType = 0x0001, VariableIndex = 0x03CF, VariableKey = roleid, VariableValue = 0x0000 };
            gameSession.SendPackage(xbb.Type, xbb.rSize, xbb);

            var role = Rolebox.Instance.GetRole(roleid);
            var rolexp = Rolebox.Instance.GetRolexp(roleid);

            var srip = new x000C()
            {
                RoleId = roleid,
                Position = new System.Drawing.Point(role.X, role.Y),
                Altitude = 0,
                Exp = role.Exp,
                DoubleExp = 0,
                MaxExp = long.MaxValue,
                PkLevel = rolexp.PkLevel,
                Direction = 0,
                Map = role.Map,
                RouteId = 1,
                Race = role.Race,
                Gender = role.Gender,
                Level = role.Level,
                AttackMode = rolexp.Attack,
                CurrentTime = UtilityLibrary.TimeShift(DateTime.Now),
                MaxLevel = 105,
                EquipRepairDto = (ushort)(1.5m * 10000m),
                AwakeningExp = 0,
                MaxAwakeningExp = 0
            };
            gameSession.SendPackage(srip.Type, srip.rSize, srip);

            var sbsp = new x000F()
            {
                BackpackSize = rolexp.BackpackSize,
                WarehouseSize = rolexp.WarehouseSize,
                ExtraBackpackSize = rolexp.ExtraBackpackSize
            };
            gameSession.SendPackage(sbsp.Type, sbsp.Size, sbsp);

            var ssip = new x0012();
            gameSession.SendPackage(ssip.Type, ssip.rSize, ssip);

            var ssbp = new x0013();
            gameSession.SendPackage(ssbp.Type, ssbp.rSize, ssbp);

            var sbpip = new x0011();
            gameSession.SendPackage(sbpip.Type, sbpip.Size, sbpip);

            var x0014 = new x0014();
            gameSession.SendPackage(x0014.Type, x0014.rSize, x0014);

            var srsp = new x000E();
            gameSession.SendPackage(srsp.Type, 0, srsp);

            var srlp = new x0016();
            gameSession.SendPackage(srlp.Type, srlp.rSize, srlp);

            var scvp = new x00BA();
            gameSession.SendPackage(scvp.Type, scvp.rSize, scvp);

            var scqp = new x0094();
            gameSession.SendPackage(scqp.Type, scqp.rSize, scqp);

            var scip = new x0120();
            gameSession.SendPackage(scip.Type, scip.Size, scip);

            var spiip = new x0142();
            gameSession.SendPackage(spiip.Type, 0, spiip);            

            xbb = new x00BB() { VariableType = 0x0001, VariableIndex = 0x00BB, VariableKey = roleid, VariableValue = 0x0000 };
            gameSession.SendPackage(xbb.Type, xbb.rSize, xbb);
            xbb = new x00BB() { VariableType = 0x0001, VariableIndex = 0x00D5, VariableKey = roleid, VariableValue = 0x0000 };
            gameSession.SendPackage(xbb.Type, xbb.rSize, xbb);
            xbb = new x00BB() { VariableType = 0x0001, VariableIndex = 0x00D8, VariableKey = roleid, VariableValue = 0x0000 };
            gameSession.SendPackage(xbb.Type, xbb.rSize, xbb);
            xbb = new x00BB() { VariableType = 0x0001, VariableIndex = 0x00DA, VariableKey = roleid, VariableValue = 0x0000 };
            gameSession.SendPackage(xbb.Type, xbb.rSize, xbb);
            xbb = new x00BB() { VariableType = 0x0001, VariableIndex = 0x00DC, VariableKey = roleid, VariableValue = 0x0000 };
            gameSession.SendPackage(xbb.Type, xbb.rSize, xbb);
            xbb = new x00BB() { VariableType = 0x0001, VariableIndex = 0x00E8, VariableKey = roleid, VariableValue = 0x0000 };
            gameSession.SendPackage(xbb.Type, xbb.rSize, xbb);
            xbb = new x00BB() { VariableType = 0x0001, VariableIndex = 0x02B4, VariableKey = roleid, VariableValue = 0x0000 };
            gameSession.SendPackage(xbb.Type, xbb.rSize, xbb);
            xbb = new x00BB() { VariableType = 0x0001, VariableIndex = 0x02B5, VariableKey = roleid, VariableValue = 0x0000 };
            gameSession.SendPackage(xbb.Type, xbb.rSize, xbb);
            xbb = new x00BB() { VariableType = 0x0001, VariableIndex = 0x02B6, VariableKey = roleid, VariableValue = 0x0000 };
            gameSession.SendPackage(xbb.Type, xbb.rSize, xbb);
            xbb = new x00BB() { VariableType = 0x0001, VariableIndex = 0x02C2, VariableKey = roleid, VariableValue = 0x0000 };
            gameSession.SendPackage(xbb.Type, xbb.rSize, xbb);
            xbb = new x00BB() { VariableType = 0x0001, VariableIndex = 0x02C3, VariableKey = roleid, VariableValue = 0x0000 };
            gameSession.SendPackage(xbb.Type, xbb.rSize, xbb);
            xbb = new x00BB() { VariableType = 0x0001, VariableIndex = 0x02C4, VariableKey = roleid, VariableValue = 0x0000 };
            gameSession.SendPackage(xbb.Type, xbb.rSize, xbb);
            xbb = new x00BB() { VariableType = 0x0001, VariableIndex = 0x0323, VariableKey = roleid, VariableValue = 0x0000 };
            gameSession.SendPackage(xbb.Type, xbb.rSize, xbb);
            xbb = new x00BB() { VariableType = 0x0001, VariableIndex = 0x0351, VariableKey = roleid, VariableValue = 0x0000 };
            gameSession.SendPackage(xbb.Type, xbb.rSize, xbb);
            xbb = new x00BB() { VariableType = 0x0001, VariableIndex = 0x0352, VariableKey = roleid, VariableValue = 0x0000 };
            gameSession.SendPackage(xbb.Type, xbb.rSize, xbb);
            xbb = new x00BB() { VariableType = 0x0001, VariableIndex = 0x0361, VariableKey = roleid, VariableValue = 0x0000 };
            gameSession.SendPackage(xbb.Type, xbb.rSize, xbb);

            var x9 = new x0009();
            x9 = new x0009() { code = 0x0808, param = 0x0000, extra = 0x0000 };
            gameSession.SendPackage(x9.Type, x9.rSize, x9);
            x9 = new x0009() { code = 0x0808, param = 0x0001, extra = 0x0000 };
            gameSession.SendPackage(x9.Type, x9.rSize, x9);
            x9 = new x0009() { code = 0x0808, param = 0x0002, extra = 0x0000 };
            gameSession.SendPackage(x9.Type, x9.rSize, x9);
            x9 = new x0009() { code = 0x0808, param = 0x0003, extra = 0x0000 };
            gameSession.SendPackage(x9.Type, x9.rSize, x9);

            var x4d = new x004D();
            x4d = new x004D() { StatId = 0x03, Value = 0x00000002 };
            gameSession.SendPackage(x4d.Type, x4d.rSize, x4d);
            x4d = new x004D() { StatId = 0x05, Value = 0x00000001 };
            gameSession.SendPackage(x4d.Type, x4d.rSize, x4d);
            x4d = new x004D() { StatId = 0x06, Value = 0x00000004 };
            gameSession.SendPackage(x4d.Type, x4d.rSize, x4d);
            x4d = new x004D() { StatId = 0x07, Value = 0x00000006 };
            gameSession.SendPackage(x4d.Type, x4d.rSize, x4d);
            x4d = new x004D() { StatId = 0x10, Value = 0x0000002A };
            gameSession.SendPackage(x4d.Type, x4d.rSize, x4d);
            x4d = new x004D() { StatId = 0x11, Value = 0x00000025 };
            gameSession.SendPackage(x4d.Type, x4d.rSize, x4d);
            x4d = new x004D() { StatId = 0x12, Value = 0x00000008 };
            gameSession.SendPackage(x4d.Type, x4d.rSize, x4d);
            x4d = new x004D() { StatId = 0x13, Value = 0x0000000C };
            gameSession.SendPackage(x4d.Type, x4d.rSize, x4d);
            x4d = new x004D() { StatId = 0x14, Value = 0x00000007 };
            gameSession.SendPackage(x4d.Type, x4d.rSize, x4d);
            x4d = new x004D() { StatId = 0x15, Value = 0x0000000E };
            gameSession.SendPackage(x4d.Type, x4d.rSize, x4d);
            x4d = new x004D() { StatId = 0x16, Value = 0x000003E8 };
            gameSession.SendPackage(x4d.Type, x4d.rSize, x4d);
            x4d = new x004D() { StatId = 0x25, Value = 0x00000001 };
            gameSession.SendPackage(x4d.Type, x4d.rSize, x4d);
            x4d = new x004D() { StatId = 0x26, Value = 0x00000001 };
            gameSession.SendPackage(x4d.Type, x4d.rSize, x4d);
            x4d = new x004D() { StatId = 0x32, Value = 0x0000000C };
            gameSession.SendPackage(x4d.Type, x4d.rSize, x4d);
            x4d = new x004D() { StatId = 0x33, Value = 0x00000019 };
            gameSession.SendPackage(x4d.Type, x4d.rSize, x4d);
            x4d = new x004D() { StatId = 0x34, Value = 0x00000043 };
            gameSession.SendPackage(x4d.Type, x4d.rSize, x4d);

            x9 = new x0009() { code = 0x0791, param = 0x0000, extra = 0x0000 };
            gameSession.SendPackage(x9.Type, x9.rSize, x9);

            var sedp = new x0021() { roleid = roleid };
            gameSession.SendPackage(sedp.Type, sedp.Size, sedp);
        }
    }
}
