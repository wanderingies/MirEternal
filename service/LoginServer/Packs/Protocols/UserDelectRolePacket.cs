#pragma warning disable CS0649
#pragma warning disable CS8618

using LoginServer.Data;
using LoginServer.Data.Enum;
using LoginServer.Service;
using System;
using System.Text;
using System.Xml.Linq;
using TouchSocket.Core;

namespace LoginServer.Packs.Protocol
{
    /// <summary>
    /// 用户删除角色
    /// </summary>
    internal class UserDelectRolePacket : Package
    {
        #region public field

        public int roleid = -1;
        public string sessionid;

        public short ResultType;
        public byte[] ResultMessage;
        #endregion

        #region public attribute

        public ushort Type => 0x03EC;
        public ushort Size => 6;
        #endregion

        #region private field

        #endregion        

        public byte[] RoleList()
        {
            using var memoryStream = new MemoryStream(new byte[847]);
            using var binaryWriter = new BinaryWriter(memoryStream);

            var alro = Userbox.Instance.GetRoles(sessionid);
            var roles = alro.Where(q => q.FreezeTime != default && q.DeleteTime == default).ToList();
            var freeze = alro.Where(q => q.FreezeTime == default && q.DeleteTime == default).ToList();

            binaryWriter.Write((byte)(Math.Min(4, roles.Count) + Math.Min(5, freeze.Count)));

            for (int i = 0; i < 4 && i < roles.Count; i++)
            {
                var pack = new UserBackRolePacket();
                binaryWriter.Write(pack.RoleInfo(roles[i].RoleId));
            }

            for (int i = 0; i < 5 && i < freeze.Count; i++)
            {
                var pack = new UserBackRolePacket();
                binaryWriter.Write(pack.RoleInfo(freeze[i].RoleId));
            }

            return memoryStream.ToArray();
        }

        public ByteBlock Marshal(ByteBlock byteBlock)
        {
            byteBlock.Write(RoleList());
            return byteBlock;
        }

        public ByteBlock UnMarshal(ByteBlock byteBlock)
        {
            roleid = byteBlock.ReadInt32();
            return byteBlock;
        }

        public void Process(LoginSession session)
        {
            var userole = Userbox.Instance.GetUserole(roleid);
            if (userole != null)
            {
                userole.DeleteTime = DateTime.Now;
                Userbox.Instance.sqlite_userole.GetConnection.Update(userole);
            }

            var role = Rolebox.Instance.GetRole(roleid);
            if (role != null)
            {
                role.DeleteTime = DateTime.Now;
                Rolebox.Instance.sqlite_role.GetConnection.Update(role);
            }

            var ucrp = new UserChangeRolePacket() { roleid = roleid };
            session.SendPackage(ucrp.Type, ucrp.Size, ucrp);
        }
    }
}

