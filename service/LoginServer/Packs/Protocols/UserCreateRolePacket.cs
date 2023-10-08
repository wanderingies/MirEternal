#pragma warning disable CS0649
#pragma warning disable CS8618

using TouchSocket.Core;
using LoginServer.Service;
using System.Text;
using LoginServer.Data;
using LoginServer.Data.Enum;
using LoginServer.Data.Types;
using GameServer.Data.Types;
using System.Reflection.Emit;

namespace LoginServer.Packs.Protocol
{
    /// <summary>
    /// 创建角色
    /// </summary>
    internal class UserCreateRolePacket : Package
    {
        #region public field

        public string name;
        
        public byte gender;
        public byte race;
        public byte hairstyle;
        public byte haircolor;
        public byte facestyle;

        public string sessionid;
        public short ResultType;
        public byte[] ResultMessage;
        #endregion

        #region public attribute

        public ushort Type => 1002;
        public ushort Size => 40;        
        #endregion

        public UserCreateRolePacket()
        {
            ResultMessage = new byte[761] {
                51, 53, 50, 54, 51, 53, 49, 57, 56, 48, 0, 56, 48, 0, 58, 50, 53, 58, 97, 97, 58, 51, 102, 58, 50, 50, 58, 48, 54, 0, 85, 76,
                83, 50, 49, 45, 53, 53, 51, 50, 101, 48, 54, 57, 50, 100, 50, 51, 52, 98, 98, 48, 57, 97, 56, 98, 99, 50, 100, 102, 100, 102,
                57, 97, 51, 1, 129, 110, 6, 0, 0, 7, 0, 0, 0, 50, 48, 49, 54, 45, 48, 50, 45, 50, 54, 0, 120, 156, 237, 86, 205, 106, 20, 65,
                16, 238, 237, 249, 91, 247, 103, 102, 93, 163, 65, 34, 26, 140, 108, 196, 104, 80, 148, 8, 122, 16, 37, 228, 224, 205, 120, 86,
                60, 120, 243, 45, 4, 197, 231, 240, 226, 197, 103, 208, 131, 111, 226, 197, 139, 55, 31, 32, 86, 237, 124, 159, 243, 109, 147,
                68, 68, 49, 151, 45, 40, 170, 187, 186, 254, 187, 171, 102, 66, 8, 161, 31, 142, 135, 218, 240, 0, 240, 81, 214, 67, 91, 95, 150,
                61, 161, 204, 66, 216, 239, 133, 80, 226, 204, 237, 151, 135, 200, 57, 20, 71, 156, 57, 239, 180, 97, 52, 92, 53, 28, 32, 206, 6,
                242, 35, 224, 24, 114, 126, 62, 193, 126, 12, 217, 10, 120, 23, 57, 184, 252, 10, 124, 85, 160, 111, 160, 119, 207, 240, 25, 120,
                174, 239, 185, 93, 17, 27, 142, 219, 240, 93, 193, 94, 9, 191, 99, 145, 217, 130, 111, 231, 63, 55, 180, 82, 132, 83, 134, 57, 228,
                11, 156, 157, 151, 156, 47, 192, 70, 1, 27, 37, 244, 106, 201, 91, 107, 52, 16, 185, 50, 89, 159, 133, 142, 211, 115, 208, 25, 128,
                94, 52, 58, 133, 31, 234, 177, 214, 121, 114, 7, 81, 116, 115, 196, 231, 245, 219, 21, 89, 173, 177, 219, 248, 146, 117, 126, 104, 231,
                12, 214, 35, 212, 180, 2, 245, 252, 54, 37, 134, 33, 248, 165, 32, 253, 215, 178, 102, 205, 41, 83, 32, 158, 74, 98, 202, 32, 83, 73,
                28, 49, 182, 57, 100, 64, 198, 77, 217, 245, 164, 190, 78, 27, 212, 139, 247, 224, 188, 91, 114, 247, 172, 147, 159, 237, 136, 78, 133,
                152, 134, 18, 55, 245, 25, 63, 145, 239, 66, 115, 90, 149, 245, 84, 98, 172, 69, 174, 150, 115, 230, 89, 225, 60, 2, 157, 71, 253, 153,
                188, 43, 98, 41, 178, 190, 191, 36, 119, 57, 0, 111, 2, 234, 50, 125, 201, 57, 38, 186, 17, 185, 228, 216, 55, 178, 207, 37, 78, 230, 50,
                183, 83, 180, 247, 151, 37, 181, 103, 158, 105, 205, 72, 153, 59, 243, 159, 98, 221, 191, 218, 233, 233, 27, 218, 16, 59, 90, 131, 70, 222,
                2, 253, 191, 180, 245, 154, 225, 157, 176, 216, 31, 140, 141, 241, 243, 110, 53, 246, 90, 234, 78, 63, 122, 87, 15, 13, 175, 75, 126, 148,
                245, 253, 135, 216, 198, 51, 146, 248, 247, 144, 219, 53, 121, 7, 236, 85, 222, 157, 203, 46, 97, 9, 127, 3, 143, 194, 226, 140, 243, 183,
                117, 3, 123, 107, 169, 121, 47, 220, 14, 109, 63, 124, 202, 91, 217, 173, 208, 245, 196, 38, 214, 251, 88, 187, 254, 12, 168, 125, 55, 16,
                29, 246, 142, 246, 30, 103, 88, 249, 27, 28, 29, 193, 143, 199, 240, 171, 100, 239, 190, 222, 199, 174, 55, 235, 68, 231, 102, 104, 231, 0,
                99, 250, 22, 22, 103, 1, 229, 118, 64, 31, 24, 110, 136, 109, 253, 46, 114, 102, 232, 108, 162, 141, 89, 232, 230, 98, 145, 212, 130, 125,
                238, 223, 131, 87, 162, 231, 176, 22, 186, 239, 140, 243, 125, 118, 12, 5, 57, 167, 117, 54, 205, 103, 164, 212, 252, 215, 28, 234, 181, 244,
                93, 236, 102, 234, 16, 53, 105, 18, 27, 7, 9, 232, 108, 36, 239, 179, 228, 249, 53, 180, 255, 136, 220, 115, 190, 189, 77, 244, 156, 238, 38,
                246, 253, 126, 248, 237, 218, 179, 24, 183, 109, 127, 127, 221, 214, 246, 32, 31, 27, 239, 71, 111, 177, 38, 147, 164, 70, 90, 103, 167, 223,
                77, 127, 37, 107, 101, 158, 134, 37, 44, 97, 9, 255, 3, 202, 19, 242, 235, 115, 237, 245, 9, 249, 254, 151, 192, 185, 235, 117, 124, 98, 243,
                235, 69, 56, 252, 187, 231, 115, 50, 251, 3, 187, 63, 1, 233, 74, 233, 158 };
        }
        
        #region private field

        
        #endregion

        public ByteBlock Marshal(ByteBlock byteBlock)
        {
            var buffer = Encoding.UTF8.GetBytes(sessionid);
            Array.Copy(buffer, 0, ResultMessage, 18, buffer.Length);
            byteBlock.Write(Utility.UtilityLibrary.EncryptionValue(ResultMessage, ResultMessage.Length));
            return byteBlock;
        }

        public ByteBlock UnMarshal(ByteBlock byteBlock)
        {
            byte[] buffer = new byte[32];
            byteBlock.Read(buffer);
            name = Encoding.UTF8.GetString(buffer).Split(new char[1], StringSplitOptions.RemoveEmptyEntries)[0];
            
            gender = byteBlock.ReadByte();
            race = byteBlock.ReadByte();
            hairstyle = byteBlock.ReadByte();
            haircolor = byteBlock.ReadByte();
            facestyle = byteBlock.ReadByte();

            return byteBlock;
        }

        public void Process(LoginSession session)
        {
            /*var count = Userbox.Instance.GetRoles();
            if (count > 1000000)
            {
                var errp = new UserLoginPacket() { errcode = 340u };
                session.SendPackage(errp.Type, errp.Size, errp);
            }*/

            var roles = Userbox.Instance.GetRoles(session.SessionId);
            var freeze = roles.Where(q => q.FreezeTime != default);
            if (freeze != null && roles.Count >= 4)
            {
                var errp = new UserLoginPacket() { errcode = 267U };
                session.SendPackage(errp.Type, errp.Size, errp);
            }

            if (Encoding.UTF8.GetBytes(name).Length > 24)
            {
                var errp = new UserLoginPacket() { errcode = 270U };
                session.SendPackage(errp.Type, errp.Size, errp);
            }

            if(Userbox.Instance.GetRole(name) != null)
            {
                var errp = new UserLoginPacket() { errcode = 272U };
                session.SendPackage(errp.Type, errp.Size, errp);
            }

            /*if (!Enum.TryParse(this.race.ToString(), out Race race) || !Enum.IsDefined(typeof(Race), race))
            {
                var errp = new UserLoginPacket() { errcode = 258U };
                session.SendPackage(errp.Type, errp.Size, errp);
            }

            if (!Enum.TryParse(this.gender.ToString(), out Gender gender) || !Enum.IsDefined(typeof(Gender), gender))
            {
                var errp = new UserLoginPacket() { errcode = 258U };
                session.SendPackage(errp.Type, errp.Size, errp);
            }

            if (!Enum.TryParse(this.haircolor.ToString(), out HairColor haircolor) || !Enum.IsDefined(typeof(HairColor), haircolor))
            {
                var errp = new UserLoginPacket() { errcode = 258U };
                session.SendPackage(errp.Type, errp.Size, errp);
            }

            if (!Enum.TryParse((this.race * 65536 + this.gender * 256 + this.hairstyle).ToString(), out HairStyle hairstyle) || !Enum.IsDefined(typeof(HairStyle), hairstyle))
            {
                var errp = new UserLoginPacket() { errcode = 258U };
                session.SendPackage(errp.Type, errp.Size, errp);
            }            

            if (!Enum.TryParse((this.race * 65536 + this.gender * 256 + this.facestyle).ToString(), out FaceStyle facestyle) || !Enum.IsDefined(typeof(FaceStyle), facestyle))
            {
                var errp = new UserLoginPacket() { errcode = 258U };
                session.SendPackage(errp.Type, errp.Size, errp);
            }*/

            var role = new Role()
            {
                Name = name,
                Race = race,
                Gender = gender,
                HairStyle = hairstyle,
                HairColor = haircolor,
                FaceStyle = facestyle,
                Level = 1,
                HP = 19,
                MP = 20,
                Map = 142
            };

            int id = Rolebox.Instance.sqlite_role.GetConnection.Insert(role);

            role = Rolebox.Instance.GetRole(name);
            var userole = new Userole()
            {
                Userid = session.SessionId,
                RoleId = role.Id,
                RoleName = name,
            };

            Userbox.Instance.sqlite_userole.GetConnection.Insert(userole);

            var package = new UserBackRolePacket() { roleid = id };
            session.SendPackage(package.Type, package.Size, package);
        }
    }
}

