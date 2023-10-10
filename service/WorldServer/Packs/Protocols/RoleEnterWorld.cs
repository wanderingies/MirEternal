#pragma warning disable CS0649
#pragma warning disable CS8618

using System.Text;
using TouchSocket.Core;
using WorldServer.Service;
using WorldServer.Utility;

namespace WorldServer.Packs.Protocols
{
    internal class RoleEnterWorld : Package
    {
        public int roleid;
        public string sessionId;

        public ushort Type => ushort.MaxValue;

        public ushort Size => ushort.MaxValue;

        public ByteBlock Marshal(ByteBlock byteBlock)
        {
            throw new NotImplementedException();
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

        public void Process(WorldSession worldSession)
        {
            worldSession.SessionId = sessionId;
            Program.service.Logger.Info($"用户({sessionId})角色({roleid}) 进入世界");
        }
    }
}
