namespace WFA.PlugIn
{
	partial class News
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(News));
			this.panelTop = new System.Windows.Forms.Panel();
			this.panelTitle = new System.Windows.Forms.Panel();
			this.lblPanelTitle = new System.Windows.Forms.Label();
			this.btnClose = new System.Windows.Forms.Button();
			this.panelItem = new System.Windows.Forms.Panel();
			this.ucScrollbar = new CustomControls.UCScrollbar();
			this.pbAniemtion = new System.Windows.Forms.PictureBox();
			this.txtMessage = new System.Windows.Forms.TextBox();
			this.lblTopic = new System.Windows.Forms.Label();
			this.panelTop.SuspendLayout();
			this.panelTitle.SuspendLayout();
			this.panelItem.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pbAniemtion)).BeginInit();
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
			this.lblPanelTitle.Size = new System.Drawing.Size(50, 19);
			this.lblPanelTitle.TabIndex = 1;
			this.lblPanelTitle.Text = "News";
			this.lblPanelTitle.MouseMove += new System.Windows.Forms.MouseEventHandler(this.lblPanelTitle_MouseMove);
			// 
			// btnClose
			// 
			this.btnClose.BackColor = System.Drawing.Color.Black;
			this.btnClose.FlatAppearance.BorderSize = 0;
			this.btnClose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(23)))), ((int)(((byte)(34)))));
			this.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(17)))), ((int)(((byte)(35)))));
			this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnClose.ForeColor = System.Drawing.Color.Black;
			this.btnClose.Image = global::WFA.PlugIn.Image.ImageResource.delete_32px;
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
			this.panelItem.Controls.Add(this.ucScrollbar);
			this.panelItem.Controls.Add(this.pbAniemtion);
			this.panelItem.Controls.Add(this.txtMessage);
			this.panelItem.Controls.Add(this.lblTopic);
			this.panelItem.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panelItem.Location = new System.Drawing.Point(0, 40);
			this.panelItem.Name = "panelItem";
			this.panelItem.Size = new System.Drawing.Size(360, 350);
			this.panelItem.TabIndex = 5;
			// 
			// ucScrollbar
			// 
			this.ucScrollbar.ChannelColor = System.Drawing.Color.Black;
			this.ucScrollbar.DownArrowImage = ((System.Drawing.Image)(resources.GetObject("ucScrollbar.DownArrowImage")));
			this.ucScrollbar.LargeChange = 10;
			this.ucScrollbar.Location = new System.Drawing.Point(324, 227);
			this.ucScrollbar.Maximum = 100;
			this.ucScrollbar.Minimum = 0;
			this.ucScrollbar.MinimumSize = new System.Drawing.Size(15, 92);
			this.ucScrollbar.Name = "ucScrollbar";
			this.ucScrollbar.Size = new System.Drawing.Size(24, 278);
			this.ucScrollbar.SmallChange = 1;
			this.ucScrollbar.TabIndex = 16;
			this.ucScrollbar.ThumbBottomImage = ((System.Drawing.Image)(resources.GetObject("ucScrollbar.ThumbBottomImage")));
			this.ucScrollbar.ThumbBottomSpanImage = ((System.Drawing.Image)(resources.GetObject("ucScrollbar.ThumbBottomSpanImage")));
			this.ucScrollbar.ThumbMiddleImage = ((System.Drawing.Image)(resources.GetObject("ucScrollbar.ThumbMiddleImage")));
			this.ucScrollbar.ThumbTopImage = ((System.Drawing.Image)(resources.GetObject("ucScrollbar.ThumbTopImage")));
			this.ucScrollbar.ThumbTopSpanImage = ((System.Drawing.Image)(resources.GetObject("ucScrollbar.ThumbTopSpanImage")));
			this.ucScrollbar.UpArrowImage = ((System.Drawing.Image)(resources.GetObject("ucScrollbar.UpArrowImage")));
			this.ucScrollbar.Value = 0;
			this.ucScrollbar.Visible = false;
			// 
			// pbAniemtion
			// 
			this.pbAniemtion.Location = new System.Drawing.Point(64, 6);
			this.pbAniemtion.Name = "pbAniemtion";
			this.pbAniemtion.Size = new System.Drawing.Size(225, 188);
			this.pbAniemtion.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pbAniemtion.TabIndex = 15;
			this.pbAniemtion.TabStop = false;
			// 
			// txtMessage
			// 
			this.txtMessage.BackColor = System.Drawing.Color.Black;
			this.txtMessage.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.txtMessage.Font = new System.Drawing.Font("Itim", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtMessage.ForeColor = System.Drawing.Color.White;
			this.txtMessage.Location = new System.Drawing.Point(12, 230);
			this.txtMessage.Multiline = true;
			this.txtMessage.Name = "txtMessage";
			this.txtMessage.ReadOnly = true;
			this.txtMessage.Size = new System.Drawing.Size(337, 0);
			this.txtMessage.TabIndex = 14;
			// 
			// lblTopic
			// 
			this.lblTopic.AutoSize = true;
			this.lblTopic.BackColor = System.Drawing.Color.Black;
			this.lblTopic.Font = new System.Drawing.Font("Itim", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
			this.lblTopic.ForeColor = System.Drawing.Color.White;
			this.lblTopic.Location = new System.Drawing.Point(7, 197);
			this.lblTopic.Name = "lblTopic";
			this.lblTopic.Size = new System.Drawing.Size(149, 27);
			this.lblTopic.TabIndex = 1;
			this.lblTopic.Text = "New Update!!";
			// 
			// News
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Black;
			this.ClientSize = new System.Drawing.Size(360, 390);
			this.ControlBox = false;
			this.Controls.Add(this.panelItem);
			this.Controls.Add(this.panelTop);
			this.Cursor = System.Windows.Forms.Cursors.Arrow;
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "News";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.panelTop.ResumeLayout(false);
			this.panelTitle.ResumeLayout(false);
			this.panelTitle.PerformLayout();
			this.panelItem.ResumeLayout(false);
			this.panelItem.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pbAniemtion)).EndInit();
			this.ResumeLayout(false);

		}
		#endregion

		private System.Windows.Forms.Panel panelTop;
		private System.Windows.Forms.Panel panelTitle;
		private System.Windows.Forms.Label lblPanelTitle;
		private System.Windows.Forms.Button btnClose;
		private System.Windows.Forms.Panel panelItem;
		private System.Windows.Forms.Label lblTopic;
		private System.Windows.Forms.TextBox txtMessage;
		private System.Windows.Forms.PictureBox pbAniemtion;
		private CustomControls.UCScrollbar ucScrollbar;
	}
}