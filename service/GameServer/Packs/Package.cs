using GameServer.Service;
using GameServer.Utility;
using TouchSocket.Core;

namespace GameServer.Packs
{
    internal interface Package
    {
        public ushort Type { get; }
        public ushort Size { get; }
        public ushort rSize {  get; }

        static Package()
        {
            var packages = Reflection.CreateAllInstancesOf<Package>().OrderBy(q => q.Type);
            foreach (var package in packages)
                AllPackage.Add(package.Type, package);
        }

        public static readonly Dictionary<ushort, Package> AllPackage = new Dictionary<ushort, Package>();

        public abstract ByteBlock Marshal(ByteBlock byteBlock);
        public abstract ByteBlock UnMarshal(ByteBlock byteBlock);
        public abstract void Process(GameSession gateSession);
    }
}
