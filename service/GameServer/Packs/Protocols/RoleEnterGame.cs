#pragma warning disable CS0649
#pragma warning disable CS8618

using GameServer.Data;
using GameServer.Service;
using GameServer.Utility;
using System.Text;
using TouchSocket.Core;

namespace GameServer.Packs.Protocols
{
    internal class RoleEnterGame : Package
    {
        public int roleid;
        public string message;

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
            message = Encoding.UTF8.GetString(buffer, 4, 13);

            return byteBlock;
        }

        public void Process(GameSession gateSession)
        {
            Program.service.Logger.Info($"角色({roleid}) 进入游戏");

            var role = Rolebox.Instance.GetRole(roleid);
            var rolexp = Rolebox.Instance.GetRolexp(roleid);

            var srip = new SyncRoleInfoPacket()
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
            gateSession.SendPackage(srip.Type, srip.Size, srip);

            var sbsp = new SyncBackpackSizePacket()
            {
                BackpackSize = rolexp.BackpackSize,
                WarehouseSize = rolexp.WarehouseSize,
                ExtraBackpackSize = rolexp.ExtraBackpackSize
            };
            gateSession.SendPackage(sbsp.Type, sbsp.Size, sbsp);

            var ssip = new SyncSkillInfoPacket();
            gateSession.SendPackage(ssip.Type, ssip.Size, ssip);

            var ssbp = new SyncShortcutbarPacket();
            gateSession.SendPackage(ssbp.Type, ssbp.Size, ssbp);

            var sbpip = new SyncBackpackInfoPacket();
            gateSession.SendPackage(sbpip.Type, sbpip.Size, sbpip);

            var srsp = new SyncRoleStatePacket();
            gateSession.SendPackage(srsp.Type, srsp.Size, srsp);

            var srlp = new SyncReputationListPacket();
            gateSession.SendPackage(srlp.Type, srlp.Size, srlp);

            var scvp = new SyncClientVariablesPacket();
            gateSession.SendPackage(scvp.Type, scvp.Size, scvp);

            var scqp = new SyncCurrencyQuantityPacket();
            gateSession.SendPackage(scqp.Type, scqp.Size, scqp);

            var scip = new SyncCheckinPacket();
            gateSession.SendPackage(scip.Type, scip.Size, scip);

            var spiip = new SyncPrivilegedInfoPacket();
            gateSession.SendPackage(spiip.Type, spiip.Size, spiip);

            var sedp = new SyncEndDataPacket() { roleid = roleid };
            gateSession.SendPackage(sedp.Type, sedp.Size, sedp);
        }
    }
}
