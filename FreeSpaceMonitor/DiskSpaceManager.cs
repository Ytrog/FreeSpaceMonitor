using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FreeSpaceMonitor
{
    /// <summary>
    /// Manage all disk space related functionality
    /// </summary>
    public class DiskSpaceManager
    {
        public DriveInfo DriveInfo { get; private set; }

        public DiskSpaceManager(string drivename)
        {
            DriveInfo = new(drivename);
        }

        public long FreeSpace => DriveInfo.AvailableFreeSpace;

        public long TotalSize => DriveInfo.TotalSize;
    }
}
