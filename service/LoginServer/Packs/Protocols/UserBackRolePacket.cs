#pragma warning disable CS0649
#pragma warning disable CS8618

using LoginServer.Data;
using LoginServer.Service;
using LoginServer.Utility;
using System.Text;
using TouchSocket.Core;

namespace LoginServer.Packs.Protocol
{
    /// <summary>
    /// 找回冻结的角色
    /// </summary>
    internal class UserBackRolePacket : Package
    {
        #region public field

        public int roleid;

        public short ResultType;
        public byte[] ResultMessage;
        #endregion

        #region public attribute

        public ushort Type => 1005;
        public ushort Size => 6;
        #endregion

        #region private field


        #endregion

        public byte[] RoleInfo(int id)
        {
            var role = Rolebox.Instance.GetRole(id);
            var memoryStream = new MemoryStream(new byte[94]);
            var binaryWriter = new BinaryWriter(memoryStream);

            if (role != null)
            {
                binaryWriter.Write(role.Id);
                binaryWriter.Write(Encoding.UTF8.GetBytes(role.Name));
                binaryWriter.Seek(61, SeekOrigin.Begin);
                binaryWriter.Write(role.Race);
                binaryWriter.Write(role.Gender);
                binaryWriter.Write(role.HairStyle);
                binaryWriter.Write(role.HairColor);
                binaryWriter.Write(role.FaceStyle);
                binaryWriter.Write((byte)0);
                binaryWriter.Write(role.Level);
                binaryWriter.Write(role.Map);
                binaryWriter.Write((byte)0);
                binaryWriter.Write(0);
                binaryWriter.Write(0);
                binaryWriter.Write(0);
                binaryWriter.Write(Computing.TimeShift(role.LastTime));
                binaryWriter.Write(role.FreezeTime == default ? 0 : Computing.TimeShift(role.FreezeTime));
            }

            return memoryStream.ToArray();
        }

        public ByteBlock Marshal(ByteBlock byteBlock)
        {
            byteBlock.Write(RoleInfo(roleid));
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
                userole.FreezeTime = default;
                Userbox.Instance.sqlite_userole.GetConnection.Update(userole);
            }

            var role = Rolebox.Instance.GetRole(roleid);
            if (role != null)
            {
                role.FreezeTime = default;
                Rolebox.Instance.sqlite_role.GetConnection.Update(role);
            }

            var tnsp = new TestNetworkSpeedPacket() { roleid = roleid };
            session.SendPackage(tnsp.Type, tnsp.Size, tnsp);
        }
    }
}

