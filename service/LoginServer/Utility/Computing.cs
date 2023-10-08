using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoginServer.Utility
{
    internal class Computing
    {
        static Computing()
        {
            SystemRelativeTime = Convert.ToDateTime("1970-01-01 08:00:00");
        }

        public static readonly DateTime SystemRelativeTime;

        public static int TimeShift(DateTime time)
        {
            return (int)(time - SystemRelativeTime).TotalSeconds;
        }

        public static ushort DateShift(DateTime date)
        {
            return (ushort)(date - SystemRelativeTime).TotalDays;
        }
    }
}
