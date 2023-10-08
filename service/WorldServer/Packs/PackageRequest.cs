#pragma warning disable CS8618

using TouchSocket.Core;

namespace WorldServer.Packs
{
    internal class PackageRequest : IRequestInfo
    {
        public ushort Type { get; set; }

        public ByteBlock ByteBlock { get; set; }
    }
}
