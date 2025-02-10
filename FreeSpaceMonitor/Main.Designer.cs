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
            notifySize.Text = "Disk Space";
            notifySize.Visible = true;
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Name = "Main";
            Text = "Free-space monitor";
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Timer driveTimer;
        private NotifyIcon notifySize;
    }
}
