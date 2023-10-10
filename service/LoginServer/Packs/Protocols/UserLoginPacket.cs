#pragma warning disable CS0649
#pragma warning disable CS8618

using TouchSocket.Core;
using LoginServer.Service;
using System.Text;
using LoginServer.Packs.RemoteProcedure;

namespace LoginServer.Packs.Protocol
{
    /// <summary>
    /// 客户登录
    /// </summary>
    internal class UserLoginPacket : Package
    {
        #region public field

        public string Ticket;

        public uint errcode;
        public uint errargs;
        public uint errexpt;
        #endregion

        #region public attribute

        public ushort Type => 0x03E9;
        public ushort Size => 164;
        #endregion

        #region private field

        #endregion

        public ByteBlock Marshal(ByteBlock byteBlock)
        {
            byteBlock.Write(errcode);
            byteBlock.Write(errargs);
            byteBlock.Write(errexpt);
            return byteBlock;
        }

        public ByteBlock UnMarshal(ByteBlock byteBlock)
        {
            byteBlock.Read(out var buffer, byteBlock.Len);
            Ticket = Encoding.UTF8.GetString(buffer, 70, 38);
            return byteBlock;
        }

        public void Process(LoginSession session)
        {
            session.SessionId = Ticket.Replace("-", "");
            // 同步协议
            var ucrp = new UserCreateRolePacket()
            { sessionid = session.SessionId };
            session.SendPackage(ucrp.Type, 0, ucrp);
            // 同步状态
            var sssp = new SyncStatusSuccessPacket();
            session.SendPackage(sssp.Type, 3, sssp);
            // 角色列表
            var udrp = new UserDelectRolePacket()
            { sessionid = session.SessionId };
            session.SendPackage(udrp.Type, 849, udrp);

            Program.service.Logger.Info($"{Ticket} 登陆成功");
        }
    }
}

