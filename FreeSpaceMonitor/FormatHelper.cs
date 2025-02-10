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
            double magnitude = Math.Log2(byteCount.Abs());

            return magnitude switch
            {
                (< 10) => $"{byteCount} B",
                (< 20) => $"{byteCount.ToKB()} KB",
                (< 30) => $"{byteCount.ToMB()} MB",
                _ => $"{byteCount.ToGB()} GB"
            };
        }

        public static ulong Abs(this long value)
        {
            return (ulong)Math.Abs(value);
        }

        public static long ToKB(this long value)
        {
            return value / 1024; 
        }

        public static long ToMB(this long value)
        {
            return value >> 20;
        }

        public static long ToGB(this long value)
        {
            return value >> 30; // TODO round to 1 decimal
        }
    }
}
