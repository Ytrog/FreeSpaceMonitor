namespace FreeSpaceMonitor
{
    public partial class Main : Form
    {
        private DiskSpaceManager DiskSpaceManager { get; set; }

        public Main()
        {
            InitializeComponent();
            DiskSpaceManager = new("C");
            if (DiskSpaceManager.DriveInfo.IsReady)
            {
                notifySize.Icon = SystemIcons.GetStockIcon(StockIconId.DriveFixed);
                SetSize();
                driveTimer.Enabled = true;
            }
        }

        private void driveTimer_Tick(object sender, EventArgs e)
        {
            SetSize();
            if (monitorToolStripMenuItem.Checked)
            {
                PopupSize();
            }
        }

        private void PopupSize()
        {
            notifySize.ShowBalloonTip(1000, "Free space", FormatDiskSpace(), IsFreeSpaceSufficient() ? ToolTipIcon.Info : ToolTipIcon.Warning); // TODO change icon
        }

        /// <summary>
        /// Check if free space is sufficient
        /// </summary>
        /// <returns></returns>
        private bool IsFreeSpaceSufficient()
        {
            return DiskSpaceManager.FreeSpace > 1 << 30;
        }

        private bool IsDiskSpaceLow()
        {
            return DiskSpaceManager.FreeSpace < 1 << 28;
        }   

        private void SetSize()
        {
            notifySize.Text = FormatDiskSpace();
            if (!IsFreeSpaceSufficient())
            {
                if (IsDiskSpaceLow())
                {
                    notifySize.Icon = SystemIcons.Error;
                }
                else
                {
                    notifySize.Icon = SystemIcons.Exclamation; 
                }
            }
            else
            {
                notifySize.Icon = SystemIcons.GetStockIcon(StockIconId.DriveFixed);
            }
        }

        private string FormatDiskSpace()
        {
            return $"Disk Space {DiskSpaceManager.FreeSpace.HumanReadable()}";
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
