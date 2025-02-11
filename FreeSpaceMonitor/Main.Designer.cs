namespace FreeSpaceMonitor
{
    partial class Main
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            driveTimer = new System.Windows.Forms.Timer(components);
            notifySize = new NotifyIcon(components);
            contextMenuStrip1 = new ContextMenuStrip(components);
            btnClose = new ToolStripMenuItem();
            contextMenuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // driveTimer
            // 
            driveTimer.Interval = 2000;
            driveTimer.Tick += driveTimer_Tick;
            // 
            // notifySize
            // 
            notifySize.BalloonTipIcon = ToolTipIcon.Info;
            notifySize.ContextMenuStrip = contextMenuStrip1;
            notifySize.Text = "Disk Space";
            notifySize.Visible = true;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { btnClose });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(104, 26);
            // 
            // btnClose
            // 
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(103, 22);
            btnClose.Text = "Close";
            btnClose.Click += btnClose_Click;
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Name = "Main";
            ShowIcon = false;
            ShowInTaskbar = false;
            Text = "Free-space monitor";
            contextMenuStrip1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Timer driveTimer;
        private NotifyIcon notifySize;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem btnClose;
    }
}
