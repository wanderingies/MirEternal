using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TouchSocket.Core;
using WorldServer.Service;
using WorldServer.Utility;

namespace WorldServer.Packs.Protocols
{
    internal class RoleEnterGame : Package
    {
        public int roleid;
        public string message;

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
            message = Encoding.UTF8.GetString(buffer, 4, 13);

            return byteBlock;
        }

        public void Process(WorldSession gateSession)
        {
            Program.service.Logger.Info($"角色({roleid}) 进入世界");
        }
    }
}
