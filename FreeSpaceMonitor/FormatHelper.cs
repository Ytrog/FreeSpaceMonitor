using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FreeSpaceMonitor
{
    public static class FormatHelper
    {
        public static string HumanReadable(this long byteCount)
        {
            Math.Log(byteCount);
        }
    }
}
