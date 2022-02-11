namespace WFA.AutoUpdater
{
    partial class AutoUpdateForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AutoUpdateForm));
			this.panelClient = new System.Windows.Forms.Panel();
			this.pbAnimetion = new System.Windows.Forms.PictureBox();
			this.DownloadingWorker = new System.ComponentModel.BackgroundWorker();
			this.panelClient.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pbAnimetion)).BeginInit();
			this.SuspendLayout();
			// 
			// panelClient
			// 
			this.panelClient.BackColor = System.Drawing.Color.Black;
			this.panelClient.Controls.Add(this.pbAnimetion);
			this.panelClient.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panelClient.Location = new System.Drawing.Point(0, 0);
			this.panelClient.Name = "panelClient";
			this.panelClient.Size = new System.Drawing.Size(211, 220);
			this.panelClient.TabIndex = 0;
			// 
			// pbAnimetion
			// 
			this.pbAnimetion.Location = new System.Drawing.Point(6, 10);
			this.pbAnimetion.Name = "pbAnimetion";
			this.pbAnimetion.Size = new System.Drawing.Size(196, 200);
			this.pbAnimetion.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pbAnimetion.TabIndex = 2;
			this.pbAnimetion.TabStop = false;
			// 
			// DownloadingWorker
			// 
			this.DownloadingWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.DownloadingWorker_DoWork);
			this.DownloadingWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.DownloadingWorker_RunWorkerCompleted);
			// 
			// AutoUpdateForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.ClientSize = new System.Drawing.Size(211, 220);
			this.ControlBox = false;
			this.Controls.Add(this.panelClient);
			this.Cursor = System.Windows.Forms.Cursors.AppStarting;
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "AutoUpdateForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Load += new System.EventHandler(this.AutoUpdaterForm_Load);
			this.panelClient.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.pbAnimetion)).EndInit();
			this.ResumeLayout(false);

		}
		#endregion

		private System.Windows.Forms.Panel panelClient;
		private System.Windows.Forms.PictureBox pbAnimetion;
		private System.ComponentModel.BackgroundWorker DownloadingWorker;
	}
}

