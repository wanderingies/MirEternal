using LoginServer.Service;
using LoginServer.Utility;
using TouchSocket.Core;

namespace LoginServer.Packs
{
    internal interface Package
    {
        static Package()
        {
            var packages = Reflection.CreateAllInstancesOf<Package>().OrderBy(q => q.Type);
            foreach(var package in packages)
                AllPackage.Add(package.Type, package);
        }

        public ushort Type { get; }
        public ushort Size { get; }

        public static readonly Dictionary<ushort, Package> AllPackage = new Dictionary<ushort, Package>();

        public abstract ByteBlock Marshal(ByteBlock byteBlock);
        public abstract ByteBlock UnMarshal(ByteBlock byteBlock);
        public abstract void Process(LoginSession gateSession);
    }
}
