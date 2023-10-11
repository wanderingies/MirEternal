#pragma warning disable CS0649
#pragma warning disable CS8618

using GameServer.Data;
using GameServer.Packs.Protocol;
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
            gameSession.SendPackage(srip.Type, srip.Size, srip);

            var sbsp = new x000F()
            {
                BackpackSize = rolexp.BackpackSize,
                WarehouseSize = rolexp.WarehouseSize,
                ExtraBackpackSize = rolexp.ExtraBackpackSize
            };
            gameSession.SendPackage(sbsp.Type, sbsp.Size, sbsp);

            var ssip = new x0012();
            gameSession.SendPackage(ssip.Type, 0, ssip);

            var ssbp = new x0013();
            gameSession.SendPackage(ssbp.Type, 0, ssbp);

            var sbpip = new x0011();
            gameSession.SendPackage(sbpip.Type, sbpip.Size, sbpip);

            var srsp = new x000E();
            gameSession.SendPackage(srsp.Type, 0, srsp);

            var srlp = new x0016();
            gameSession.SendPackage(srlp.Type, srlp.Size, srlp);

            var scvp = new x00BA();
            gameSession.SendPackage(scvp.Type, scvp.Size, scvp);

            var scqp = new x0094();
            gameSession.SendPackage(scqp.Type, 0, scqp);

            var scip = new x0120();
            gameSession.SendPackage(scip.Type, scip.Size, scip);

            var spiip = new x0142();
            gameSession.SendPackage(spiip.Type, 0, spiip);

            var sedp = new x0021() { roleid = roleid };
            gameSession.SendPackage(sedp.Type, sedp.Size, sedp);
        }
    }
}
