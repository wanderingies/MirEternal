using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GateServer.Data.Enums
{
    internal enum SessionState
    {
        None = 0,
        UserInLogin = 1001,
        RoleInGame = 2001,
    }
}
