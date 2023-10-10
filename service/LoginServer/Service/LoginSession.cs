#pragma warning disable CS0649
#pragma warning disable CS8618

using LoginServer.Packs;
using System.Runtime.InteropServices;
using System.Text;
using TouchSocket.Core;
using TouchSocket.Sockets;

namespace LoginServer.Service
{
    internal class LoginSession : SocketClient
    {
        public LoginSession() { }

        public string SessionId {  get; set; }

        public bool SendRaw(ushort type, ushort size, byte[] value)
        {
            var byteBlock = new ByteBlock();
            byteBlock.Write(type);

            if (size == 0)
                byteBlock.Write((ushort)(value.Length + 4));

            byteBlock.Write(value);
            this.Send(byteBlock);
            return true;
        }

        public bool SendPackage(ushort type, ushort size, Package package)
        {
            var marshal = package.Marshal(new ByteBlock());
            var byteBlock = new ByteBlock();
            byteBlock.Write(type);

            if (size == 0)
                byteBlock.Write((ushort)(marshal.Len + 4));

            byteBlock.Write(marshal);
            this.Send(byteBlock);
            return true;
        }

        protected override bool HandleSendingData(byte[] buffer, int offset, int length)
        {
            buffer = Utility.UtilityLibrary.EncryptionValue(buffer, length);            

            return base.HandleSendingData(buffer, offset, length);
        }

        protected override bool HandleReceivedData(ByteBlock byteBlock, IRequestInfo requestInfo)
        {
            var request = requestInfo as PackageRequest;
            if (request != null && Package.AllPackage.TryGetValue(request.Type, out var package))
            {
                package.UnMarshal(request.ByteBlock);
                package.Process(this);
                return true;
            }

            return base.HandleReceivedData(byteBlock, requestInfo);
        }
    }
}
