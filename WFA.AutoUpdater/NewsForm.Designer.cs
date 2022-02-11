namespace WFA.AutoUpdater
{
	partial class NewsForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewsForm));
			this.panelTop = new System.Windows.Forms.Panel();
			this.panelTitle = new System.Windows.Forms.Panel();
			this.lblPanelTitle = new System.Windows.Forms.Label();
			this.btnClose = new System.Windows.Forms.Button();
			this.panelItem = new System.Windows.Forms.Panel();
			this.lklblGithub = new System.Windows.Forms.LinkLabel();
			this.lblDetail = new System.Windows.Forms.Label();
			this.lblTopic = new System.Windows.Forms.Label();
			this.pbAnimetion = new System.Windows.Forms.PictureBox();
			this.panelTop.SuspendLayout();
			this.panelTitle.SuspendLayout();
			this.panelItem.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pbAnimetion)).BeginInit();
			this.SuspendLayout();
			// 
			// panelTop
			// 
			this.panelTop.BackColor = System.Drawing.Color.Black;
			this.panelTop.Controls.Add(this.panelTitle);
			this.panelTop.Controls.Add(this.btnClose);
			this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
			this.panelTop.Location = new System.Drawing.Point(0, 0);
			this.panelTop.Name = "panelTop";
			this.panelTop.Size = new System.Drawing.Size(360, 40);
			this.panelTop.TabIndex = 1;
			this.panelTop.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelTop_MouseMove);
			// 
			// panelTitle
			// 
			this.panelTitle.Controls.Add(this.lblPanelTitle);
			this.panelTitle.Dock = System.Windows.Forms.DockStyle.Left;
			this.panelTitle.Location = new System.Drawing.Point(0, 0);
			this.panelTitle.Name = "panelTitle";
			this.panelTitle.Size = new System.Drawing.Size(256, 40);
			this.panelTitle.TabIndex = 0;
			this.panelTitle.MouseMove += new System.Windows.Forms.MouseEventHandler(this.lblPanelTitle_MouseMove);
			// 
			// lblPanelTitle
			// 
			this.lblPanelTitle.AutoSize = true;
			this.lblPanelTitle.Font = new System.Drawing.Font("Itim", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblPanelTitle.ForeColor = System.Drawing.Color.White;
			this.lblPanelTitle.Location = new System.Drawing.Point(15, 10);
			this.lblPanelTitle.Name = "lblPanelTitle";
			this.lblPanelTitle.Size = new System.Drawing.Size(154, 19);
			this.lblPanelTitle.TabIndex = 1;
			this.lblPanelTitle.Text = "AfraidPikunFlower";
			this.lblPanelTitle.MouseMove += new System.Windows.Forms.MouseEventHandler(this.lblPanelTitle_MouseMove);
			// 
			// btnClose
			// 
			this.btnClose.BackColor = System.Drawing.Color.Black;
			this.btnClose.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnClose.BackgroundImage")));
			this.btnClose.FlatAppearance.BorderSize = 0;
			this.btnClose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(23)))), ((int)(((byte)(34)))));
			this.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(17)))), ((int)(((byte)(35)))));
			this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnClose.ForeColor = System.Drawing.Color.Black;
			this.btnClose.Location = new System.Drawing.Point(324, 3);
			this.btnClose.Name = "btnClose";
			this.btnClose.Size = new System.Drawing.Size(33, 33);
			this.btnClose.TabIndex = 1;
			this.btnClose.UseVisualStyleBackColor = false;
			this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
			// 
			// panelItem
			// 
			this.panelItem.BackColor = System.Drawing.Color.Black;
			this.panelItem.Controls.Add(this.lklblGithub);
			this.panelItem.Controls.Add(this.lblDetail);
			this.panelItem.Controls.Add(this.lblTopic);
			this.panelItem.Controls.Add(this.pbAnimetion);
			this.panelItem.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panelItem.Location = new System.Drawing.Point(0, 40);
			this.panelItem.Name = "panelItem";
			this.panelItem.Size = new System.Drawing.Size(360, 341);
			this.panelItem.TabIndex = 5;
			// 
			// lklblGithub
			// 
			this.lklblGithub.ActiveLinkColor = System.Drawing.Color.Navy;
			this.lklblGithub.AutoSize = true;
			this.lklblGithub.Cursor = System.Windows.Forms.Cursors.Help;
			this.lklblGithub.Font = new System.Drawing.Font("Itim", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
			this.lklblGithub.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(125)))), ((int)(((byte)(154)))));
			this.lklblGithub.Location = new System.Drawing.Point(271, 80);
			this.lklblGithub.Name = "lklblGithub";
			this.lklblGithub.Size = new System.Drawing.Size(65, 23);
			this.lklblGithub.TabIndex = 3;
			this.lklblGithub.TabStop = true;
			this.lklblGithub.Text = "Github";
			this.lklblGithub.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(225)))), ((int)(((byte)(254)))));
			this.lklblGithub.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lklblGithub_LinkClicked);
			// 
			// lblDetail
			// 
			this.lblDetail.AutoSize = true;
			this.lblDetail.BackColor = System.Drawing.Color.Black;
			this.lblDetail.Font = new System.Drawing.Font("Itim", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
			this.lblDetail.ForeColor = System.Drawing.Color.White;
			this.lblDetail.Location = new System.Drawing.Point(16, 57);
			this.lblDetail.Name = "lblDetail";
			this.lblDetail.Size = new System.Drawing.Size(259, 46);
			this.lblDetail.TabIndex = 2;
			this.lblDetail.Text = "There is a new version update, \r\nplease download a new one at ";
			// 
			// lblTopic
			// 
			this.lblTopic.AutoSize = true;
			this.lblTopic.BackColor = System.Drawing.Color.Black;
			this.lblTopic.Font = new System.Drawing.Font("Itim", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
			this.lblTopic.ForeColor = System.Drawing.Color.White;
			this.lblTopic.Location = new System.Drawing.Point(15, 21);
			this.lblTopic.Name = "lblTopic";
			this.lblTopic.Size = new System.Drawing.Size(87, 27);
			this.lblTopic.TabIndex = 1;
			this.lblTopic.Text = "OOPS!!";
			// 
			// pbAnimetion
			// 
			this.pbAnimetion.Location = new System.Drawing.Point(75, 129);
			this.pbAnimetion.Name = "pbAnimetion";
			this.pbAnimetion.Size = new System.Drawing.Size(200, 200);
			this.pbAnimetion.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pbAnimetion.TabIndex = 0;
			this.pbAnimetion.TabStop = false;
			// 
			// NewsForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
			this.ClientSize = new System.Drawing.Size(360, 381);
			this.ControlBox = false;
			this.Controls.Add(this.panelItem);
			this.Controls.Add(this.panelTop);
			this.Cursor = System.Windows.Forms.Cursors.Arrow;
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "NewsForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.panelTop.ResumeLayout(false);
			this.panelTitle.ResumeLayout(false);
			this.panelTitle.PerformLayout();
			this.panelItem.ResumeLayout(false);
			this.panelItem.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pbAnimetion)).EndInit();
			this.ResumeLayout(false);

		}
		#endregion

		private System.Windows.Forms.Panel panelTop;
		private System.Windows.Forms.Panel panelTitle;
		private System.Windows.Forms.Label lblPanelTitle;
		private System.Windows.Forms.Button btnClose;
		private System.Windows.Forms.Panel panelItem;
		private System.Windows.Forms.PictureBox pbAnimetion;
		private System.Windows.Forms.LinkLabel lklblGithub;
		private System.Windows.Forms.Label lblDetail;
		private System.Windows.Forms.Label lblTopic;
	}
}