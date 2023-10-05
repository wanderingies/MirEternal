using GateServer.Service;
using GateServer.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TouchSocket.Core;
using TouchSocket.Sockets;

namespace GateServer.Packs
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
        public abstract void Process(GateSession gateSession);
    }
}
