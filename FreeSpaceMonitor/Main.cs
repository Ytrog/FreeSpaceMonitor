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
            notifySize.ShowBalloonTip(1000, "Free space", FormatDiskSpace(), ToolTipIcon.Info);
        }

        private void SetSize()
        {
            notifySize.Text = FormatDiskSpace();
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
