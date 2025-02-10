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
                driveTimer.Enabled = true;
            }
        }

        private void driveTimer_Tick(object sender, EventArgs e)
        {
            notifySize.Text = $"Disk Space {DiskSpaceManager.FreeSpace.HumanReadable()}";
        }
    }
}
