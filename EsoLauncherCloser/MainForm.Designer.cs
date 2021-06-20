
namespace EsoLauncherCloser
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.trayIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.timerLauncherAutoClose = new System.Windows.Forms.Timer(this.components);
            this.timerLauncherInactiveClose = new System.Windows.Forms.Timer(this.components);
            this.timerLightAttackWeave = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // trayIcon
            // 
            this.trayIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("trayIcon.Icon")));
            this.trayIcon.Text = "ESO Launcher Closer";
            this.trayIcon.Visible = true;
            // 
            // timerLauncherAutoClose
            // 
            this.timerLauncherAutoClose.Interval = 1000;
            this.timerLauncherAutoClose.Tick += new System.EventHandler(this.timerLauncherAutoClose_Tick);
            // 
            // timerLauncherInactiveClose
            // 
            this.timerLauncherInactiveClose.Interval = 1000;
            this.timerLauncherInactiveClose.Tick += new System.EventHandler(this.timerLauncherInactiveClose_Tick);
            // 
            // timerLightAttackWeave
            // 
            this.timerLightAttackWeave.Interval = 1000;
            this.timerLightAttackWeave.Tick += new System.EventHandler(this.timerAutoHotKeyManager_Tick);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(221, 177);
            this.Name = "MainForm";
            this.ShowInTaskbar = false;
            this.Text = "HiddenForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.NotifyIcon trayIcon;
        private System.Windows.Forms.Timer timerLauncherAutoClose;
        private System.Windows.Forms.Timer timerLauncherInactiveClose;
        private System.Windows.Forms.Timer timerLightAttackWeave;
    }
}

