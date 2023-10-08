using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GateServer.Packs.Protocols
{
    internal class GameProtocols
    {
        public static readonly Dictionary<ushort, BaseProtocol> Instance;

        static GameProtocols()
        {
            Instance = new Dictionary<ushort, BaseProtocol>()
            {
            };
        }
    }
}
