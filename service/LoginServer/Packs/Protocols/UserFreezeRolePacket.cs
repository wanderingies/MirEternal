#pragma warning disable CS0649
#pragma warning disable CS8618

using LoginServer.Data;
using LoginServer.Service;
using System.Net.Sockets;
using TouchSocket.Core;

namespace LoginServer.Packs.Protocol
{
    /// <summary>
    /// 冻结角色
    /// </summary>
    internal class UserFreezeRolePacket : Package
    {
        #region public field

        public int roleid;

        public short ResultType;
        public byte[] ResultMessage;
        #endregion

        #region public attribute

        public ushort Type => 1003;
        public ushort Size => 6;        
        #endregion
        
        #region private field

        
        #endregion

        public ByteBlock Marshal(ByteBlock byteBlock)
        {
            byteBlock.Write(roleid);
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
            if(userole != null)
            {
                userole.FreezeTime = DateTime.Now;
                Userbox.Instance.sqlite_userole.GetConnection.Update(userole);
            }

            var role = Rolebox.Instance.GetRole(roleid);
            if(role != null)
            {
                role.FreezeTime = DateTime.Now;
                Rolebox.Instance.sqlite_role.GetConnection.Update(role);
            }

            var uep = new UserEnterPacket() { roleid = roleid };
            session.SendPackage(uep.Type, uep.Size, uep);
        }
    }
}

