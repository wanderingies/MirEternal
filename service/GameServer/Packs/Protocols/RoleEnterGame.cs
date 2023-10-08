#pragma warning disable CS0649
#pragma warning disable CS8618

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
        }
    }
}
