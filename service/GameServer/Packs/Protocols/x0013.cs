#pragma warning disable CS8618

using TouchSocket.Core;
using GameServer.Service;
using GameServer.Data;

namespace GameServer.Packs.Protocols
{
    /// <summary>
    /// <para>请求对象外观</para>
    /// <para>快捷栏描述</para>
    /// </summary>
    internal class x0013 : Package
    {
        #region public

        public int ObjId;
        public int StateId;
        #endregion

        #region marshal

        public byte[] Shortcutbar;
        #endregion

        #region attribute

        public ushort Type => 0x0013;
        public ushort Size => 10;
        public ushort rSize => 0;
        #endregion

        public x0013()
        {
            Shortcutbar = new byte[] { 0 };
        }

        #region private


        #endregion

        public ByteBlock Marshal(ByteBlock byteBlock)
        {
            byteBlock.Write(Shortcutbar);
            return byteBlock;
        }

        public ByteBlock UnMarshal(ByteBlock byteBlock)
        {
            ObjId = byteBlock.ReadInt32();
            StateId = byteBlock.ReadInt32();
            return byteBlock;
        }

        public void Process(GameSession gameSession)
        {
            var role = Rolebox.Instance.GetRole(ObjId);
            var rolexp = Rolebox.Instance.GetRolexp(ObjId);

            if (role == null) return;

            var x40 = new x0040()
            {
                ObjectId = ObjId,
                PKLevel = rolexp.PkLevel,
                Race = role.Race,
                Gender = role.Gender,
                HairType = role.HairStyle,
                HairColor = role.HairColor,
                Face = role.FaceStyle,
                StallStatus = rolexp.StreetStallState,
                BoothName = rolexp.StreetStallName,
                WeaponType = /*playerObj.Equipment.TryGetValue(0, out var EquipmentData) ? EquipmentData.升级次数?.V ?? 0 : (byte)*/0,
                WeaponBody = /*EquipmentData?.对应模板?.V.Id ?? */0,
                Clothes = /*playerObj.Equipment.TryGetValue(1, out var EquipmentData2) ? EquipmentData2.对应模板?.V?.Id ?? 0 : */0,
                Cloak = /*playerObj.Equipment.TryGetValue(2, out var EquipmentData3) ? EquipmentData3.对应模板?.V?.Id ?? 0 : */0,
                CurrentHP = /*playerObj[GameObjectStats.MaxHP]*/role.HP,
                CurrentMP = /*playerObj[GameObjectStats.MaxMP]*/role.Map,
                Name = role.Name,
                GuildId = /*playerObj.Guild?.Index.V ?? */0,
            };

            gameSession.SendPackage(x40.Type, x40.rSize, x40);
        }
    }
}

