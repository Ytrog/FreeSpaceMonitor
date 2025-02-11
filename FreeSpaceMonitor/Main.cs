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
        }

        private void SetSize()
        {
            notifySize.Text = $"Disk Space {DiskSpaceManager.FreeSpace.HumanReadable()}";
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
