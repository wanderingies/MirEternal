using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoginServer.Data.Enum
{
    internal enum Direction
    {
        左方,
        左上 = 1024,
        上方 = 2048,
        右上 = 3072,
        右方 = 4096,
        右下 = 5120,
        下方 = 6144,
        左下 = 7168
    }
}
