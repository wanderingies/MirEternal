using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GateServer.Packs.Protocols
{
    internal class WorldProtocols
    {
        public static readonly Dictionary<ushort, BaseProtocol> Instance;

        static WorldProtocols()
        {
            Instance = new Dictionary<ushort, BaseProtocol>()
            {
            };
        }
    }
}
