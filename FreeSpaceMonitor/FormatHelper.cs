using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FreeSpaceMonitor
{
    public static class FormatHelper
    {
        const double kbFactor = 1 << 10; 
        const double mbFactor = 1 << 20;
        const double gbFactor = 1 << 30;

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

        public static double ToKB(this long bytes)
        {
            return Math.Round(bytes / kbFactor, 2); 
        }

        public static double ToMB(this long bytes)
        {
            return Math.Round(bytes / mbFactor, 2);
        }

        public static double ToGB(this long bytes)
        {
            return Math.Round(bytes / gbFactor, 2);
        }
    }
}
