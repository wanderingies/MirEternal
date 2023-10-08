#pragma warning disable CS0649
#pragma warning disable CS8618

using TouchSocket.Core;
using LoginServer.Service;
using LoginServer.Packs.RemoteProcedure;
using System;
using LoginServer.Utility;
using System.Text;
using TouchSocket.Sockets;

namespace LoginServer.Packs.Protocol
{
    /// <summary>
    /// 进入游戏
    /// </summary>
    internal class UserEnterPacket : Package
    {
        #region public field

        public int roleid;

        public short ResultType;
        public byte[] ResultMessage;
        #endregion

        #region public attribute

        public ushort Type => 1006;
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

            return byteBlock;
        }

        public void Process(LoginSession session)
        {
            var ufrp = new UserFreezeRolePacket() { roleid = roleid };
            session.SendPackage(ufrp.Type, ufrp.Size, ufrp);

            var buffer = Encoding.UTF8.GetBytes("userlogindone");
            session.Send(buffer, 0, buffer.Length);

            /*var ssvp = new SyncSupplementaryVariablesPacket()
            {
                VariableType = 1,
                VariableIndex = 132,
                VariableValue = 1,
                VariableObject = roleid,
            };
            session.SendPackage(ssvp.Type, ssvp.Size, ssvp);

            session.SendRaw(169, 14, new byte[] { 1, 0, 0, 0, 3, 0, 0, 0, 10, 0, 0, 0 });
            session.SendRaw(177, 4, new byte[] { 13, 0 });
            session.SendRaw(177, 4, new byte[] { 17, 0 });
            session.SendRaw(177, 4, new byte[] { 18, 0 });
            session.SendRaw(177, 4, new byte[] { 24, 0 });

            ssvp = new SyncSupplementaryVariablesPacket()
            {
                VariableType = 1,
                VariableIndex = 112,
                VariableValue = Computing.TimeShift(DateTime.Now),
                VariableObject = roleid,
            };
            session.SendPackage(ssvp.Type, ssvp.Size, ssvp);

            ssvp = new SyncSupplementaryVariablesPacket()
            {
                VariableType = 1,
                VariableIndex = 975,
                VariableValue = Computing.TimeShift(DateTime.Now),
                VariableObject = roleid,
            };
            session.SendPackage(ssvp.Type, ssvp.Size, ssvp);

            ssvp = new SyncSupplementaryVariablesPacket()
            {
                VariableType = 1,
                VariableIndex = 50,
                VariableValue = 3680,
                VariableObject = roleid,
            };
            session.SendPackage(ssvp.Type, ssvp.Size, ssvp);

            session.SendRaw(280, 4, new byte[] { 0, 0 });
            session.SendRaw(281, 4, new byte[] { 0, 0 });
            //session.SendRaw(296, 0, u2);
            //session.SendRaw(20, 0, GetQuestProgressData());
            //session.SendRaw(29, 0, GetAchievementProgress());
            session.SendRaw(169, 14, new byte[] { 0, 0, 0, 0, 6, 0, 0, 0, 6, 0, 0, 0 });
            session.SendRaw(169, 14, new byte[] { 1, 0, 0, 0, 3, 0, 0, 0, 10, 0, 0, 0 });
            session.SendRaw(221, 10, new byte[] { 47, 0, 0, 0, 0, 0, 0, 0 });
            session.SendRaw(182, 10, new byte[] { 255, 255, 255, 255, 255, 255, 255, 255 });
            session.SendRaw(207, 0, new byte[] { 0 });
            session.SendRaw(23, 6, new byte[] { 0, 0, 0, 0 });
            session.SendRaw(16, 34, new byte[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 });
            session.SendRaw(185, 0, new byte[] { 50, 0, 0, 6, 0, 0, 132, 0, 1, 0, 0, 0, 151, 0, 58, 41, 2, 99, 25, 3, 1, 0, 0, 0, 171, 3, 14, 0, 0, 0 });
            session.SendRaw(221, 10, new byte[] { 47, 0, 0, 0, 0, 0, 0, 0 });

            var ufrps = new UserFreezeRolePacket() { roleid = roleid };
            session.SendPackage(33, ufrps.Size, ufrps);*/
        }
    }
}

