namespace FreeSpaceMonitor
{
    public partial class Main : Form
    {
        private DiskSpaceManager DiskSpaceManager { get; set; }

        public Main()
        {
            InitializeComponent();
            DiskSpaceManager = new("C");
        }

        private void driveTimer_Tick(object sender, EventArgs e)
        {

        }
    }
}
