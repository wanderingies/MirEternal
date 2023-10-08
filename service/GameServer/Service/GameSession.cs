using GameServer.Packs;
using TouchSocket.Core;
using TouchSocket.Sockets;

namespace GameServer.Service
{
    internal class GameSession : SocketClient
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
