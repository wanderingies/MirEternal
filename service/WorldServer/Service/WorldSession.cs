using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TouchSocket.Core;
using TouchSocket.Sockets;
using WorldServer.Packs;

namespace WorldServer.Service
{
    internal class WorldSession : SocketClient
    {
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
