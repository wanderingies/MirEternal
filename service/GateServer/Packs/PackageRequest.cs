#pragma warning disable CS8618

using TouchSocket.Core;

namespace GateServer.Packs
{
    internal class PackageRequest : IRequestInfo
    {
        public ushort Type { get; set; }

        public byte[] Buffer { get; set; }
    }
}
